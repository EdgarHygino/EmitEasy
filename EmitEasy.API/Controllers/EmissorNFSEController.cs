using EmitEasy.Infra.Dados.Context;
using EmitEasy.Models.Entities;
using EmitEasy.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmitEasy.API.Controllers
{
    [Route("api/emite-nfse")]
    [ApiController]
    public class EmissorNFSEController: ControllerBase
    {
        private readonly EmitEasyDbContext _context;

        public EmissorNFSEController(EmitEasyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var empresas = _context.Nfse.Include(e => e.Empresa).Include(e => e.Cliente).Where(e => !e.IsDelete).ToList();
            return Ok(empresas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var notafical = _context.Nfse
                    .SingleOrDefault(e => e.Id == id);

            if (notafical == null) return NotFound();

            return Ok(notafical);
        }

        [HttpPost]
        public IActionResult Insert(NotaFiscalServico notaFiscal)
        {
            _context.Nfse.Add(notaFiscal);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = notaFiscal.Id }, notaFiscal);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, NotaFiscalServico input)
        {
            var notaFiscal = _context.Nfse.SingleOrDefault(d => d.Id == id);

            if (notaFiscal == null) return NotFound();

            notaFiscal.Update(
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

            _context.Nfse.Update(notaFiscal);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var notafical = _context.Nfse.SingleOrDefault(d => d.Id == id);

            if (notafical == null) return NotFound();

            notafical.Delete();
            _context.SaveChanges();
            return NoContent();
        }
    }
}
