using EmitEasy.Infra.Dados.Context;
using EmitEasy.Models.Entities;
using EmitEasy.Models.Interfaces;

namespace EmitEasy.Infra.Dados.Repositorios
{
    public class ClienteRepositorio: IClienteRepositorio
    {
        private readonly EmitEasyDbContext _context;

        public ClienteRepositorio(EmitEasyDbContext context)
        {
            _context = context;
        }

        public List<Cliente> GetAll()
        {
            var clientes = _context.Cliente.Where(e => e.Ativo).ToList();

            return clientes;
        }

        public Cliente GetById(Guid id)
        {
            var clientes = _context.Cliente
                    .SingleOrDefault(e => e.Id == id);

            return clientes;
        }


        public Cliente Insert(Cliente clientes)
        {
            _context.Cliente.Add(clientes);
            _context.SaveChanges();

            return clientes;
        }


        public bool Update(Guid id, Cliente imput)
        {
            var cliente = _context.Cliente.SingleOrDefault(d => d.Id == id);

            if (cliente == null) return false;

            cliente.Update(imput.RazaoSocial, imput.NomeFantasia, imput.InscricaoEstadual, imput.InscricaoMunicial, imput.Nome,
            imput.Descricao, imput.Email, imput.Telefone, imput.Celular, imput.Cep, imput.Rua, imput.Numero, imput.Cidade, imput.Pais,
            imput.Bairro, imput.Estado, imput.Complemento, imput.CodMunicipio);

            _context.Cliente.Update(cliente);
            _context.SaveChanges();

            return true;
        }


        public bool Delete(Guid id)
        {
            var clientes = _context.Cliente.SingleOrDefault(d => d.Id == id);

            if (clientes == null) return false;

            clientes.Delete();
            _context.SaveChanges();
            return true;
        }
    }
}
