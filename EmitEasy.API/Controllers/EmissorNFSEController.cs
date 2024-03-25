using EmitEasy.Infra.Dados.Context;
using EmitEasy.Models.Entities;
using EmitEasy.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmitEasy.API.Controllers
{
    [Route("api/[controller]")]
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
            var empresas = _context.Nfse.Where(e => !e.IsDelete).ToList();
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
        public IActionResult Insert(NotaFiscalServico notafical)
        {
            _context.Nfse.Add(notafical);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = notafical.Id }, notafical);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, NotaFiscalServico imput)
        {
            var notafical = _context.Nfse.SingleOrDefault(d => d.Id == id);

            if (notafical == null) return NotFound();

            notafical.Update(imput.RazaoSocial, imput.NomeFantasia, imput.InscricaoEstadual, imput.InscricaoMunicial, imput.Nome,
            imput.Descricao, imput.Email, imput.Telefone, imput.Celular, imput.Cep, imput.Rua, imput.Numero, imput.Cidade, imput.Pais,
            imput.Bairro, imput.Estado, imput.Complemento, imput.CodMunicipio);

            _context.Nfse.Update(notafical);
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
}
