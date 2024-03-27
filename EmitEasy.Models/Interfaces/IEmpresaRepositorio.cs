using EmitEasy.Models.Entities;

namespace EmitEasy.Models.Interfaces
{
    public interface IEmpresaRepositorio
    {
        List<Empresa> GetAll();
        Empresa GetById(Guid id);
        Empresa Insert(Empresa input);
        bool Update(Guid id, Empresa input);
        bool Delete(Guid id);
    }
}
