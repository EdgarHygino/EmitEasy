using EmitEasy.Models.Entities;

namespace EmitEasy.Models.Interfaces
{
    public interface INfseRepositorio
    {
        List<NotaFiscalServico> GetAll();
        NotaFiscalServico GetById(Guid id);
        NotaFiscalServico Insert(NotaFiscalServico input);
        bool Update(Guid id, NotaFiscalServico input);
        bool Delete(Guid id);
    }
}
