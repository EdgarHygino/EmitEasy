using EmitEasy.Models.Entities;

namespace EmitEasy.Models.Interfaces
{
    public interface IClienteRepositorio
    {
        List<Cliente> GetAll();
        Cliente GetById(Guid id);
        Cliente Insert(Cliente cliente);
        bool Update(Guid id, Cliente cliente);
        bool Delete(Guid id);
    }
}
