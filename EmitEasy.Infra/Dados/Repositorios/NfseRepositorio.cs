using EmitEasy.Infra.Dados.Context;
using EmitEasy.Models.Entities;
using EmitEasy.Models.Interfaces;

namespace EmitEasy.Infra.Dados.Repositorios
{
    public class NfseRepositorio: INfseRepositorio
    {
        private readonly EmitEasyDbContext _context;

        public NfseRepositorio(EmitEasyDbContext context)
        {
            _context = context;
        }

        public List<NotaFiscalServico> GetAll()
        {
            var notaFiscalServicos = _context.Nfse.Where(e => e.IsDelete == false).ToList();

            return notaFiscalServicos;
        }

        public NotaFiscalServico GetById(Guid id)
        {
            var NotaFiscalServico = _context.Nfse
                    .SingleOrDefault(e => e.Id == id);

            if(NotaFiscalServico == null) return null;

            return NotaFiscalServico;
        }


        public NotaFiscalServico Insert(NotaFiscalServico notaFiscalServico)
        {
            _context.Nfse.Add(notaFiscalServico);
            _context.SaveChanges();

            return notaFiscalServico;
        }


        public bool Update(Guid id, NotaFiscalServico input)
        {
            var notaFiscalServico = _context.Nfse.SingleOrDefault(d => d.Id == id);

            if (notaFiscalServico == null) return false;

            notaFiscalServico.Update(
                input.Rps,
                input.NumeroNfs,
                input.Serie,
                input.NaturezaOperacao,
                input.MunicipioIncidenciaIssqn,
                input.DataEmissao,
                input.DescricaoServico,
                input.ItemServico,
                input.ValorRetido,
                input.DescontarImposto,
                input.ValorServico,
                input.BaseCalculo,
                input.Aliquota,
                input.ValorDeducao,
                input.Desconto,
                input.AliquotaCofins,
                input.AliquotaPis,
                input.AliquotaCsll,
                input.AliquotaIr,
                input.AliquotaInss,
                input.ValorCofins,
                input.ValorPis,
                input.ValorCsll,
                input.ValorIr,
                input.ValorInss,
                input.ValorTotalNfse,
                input.Observacao,
                input.DataCancelamento,
                input.ClienteId,
                input.EmpresaId
            );

            _context.Nfse.Update(notaFiscalServico);
            _context.SaveChanges();

            return true;
        }


        public bool Delete(Guid id)
        {
            var notaFiscalServico = _context.Nfse.SingleOrDefault(d => d.Id == id);

            if (notaFiscalServico == null) return false;

            notaFiscalServico.Delete();
            _context.SaveChanges();
            return true;
        }
    }
}
