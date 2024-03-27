using EmitEasy.Infra.Dados.Context;
using EmitEasy.Models.Interfaces;
using EmitEasy.Models.Entities;

namespace EmitEasy.Infra.Dados.Repositorios
{
    public class EmpresaRepositorio: IEmpresaRepositorio
    {

        private readonly EmitEasyDbContext _context;

        public EmpresaRepositorio(EmitEasyDbContext context)
        {
            _context = context;
        }

        public List<Empresa> GetAll()
        {
            var empresas = _context.Empresa.Where(e => e.Ativo).ToList();

            return empresas;
        }

        public Empresa GetById(Guid id)
        {
            var empresa = _context.Empresa
                    .SingleOrDefault(e => e.Id == id);

            return empresa;
        }

        
        public Empresa Insert(Empresa empresa)
        {
            _context.Empresa.Add(empresa);
            _context.SaveChanges();

            return empresa;
        }

        
        public bool Update(Guid id, Empresa imput)
        {
            var empresa = _context.Empresa.SingleOrDefault(d => d.Id == id);

            if (empresa == null) return false;

            empresa.Update(imput.RazaoSocial, imput.NomeFantasia, imput.InscricaoEstadual, imput.InscricaoMunicial, imput.Nome,
            imput.Descricao, imput.Email, imput.Telefone, imput.Celular, imput.Cep, imput.Rua, imput.Numero, imput.Cidade, imput.Pais,
            imput.Bairro, imput.Estado, imput.Complemento, imput.CodMunicipio);

            _context.Empresa.Update(empresa);
            _context.SaveChanges();

            return true;
        }

        
        public bool Delete(Guid id)
        {
            var empresa = _context.Empresa.SingleOrDefault(d => d.Id == id);

            if (empresa == null) return false;

            empresa.Delete();
            _context.SaveChanges();
            return true;
        }


    }
}
