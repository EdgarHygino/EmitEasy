using EmitEasy.Infra.Dados.Context;
using EmitEasy.Models.Entities;
using EmitEasy.Models.Interfaces;
using EmitEasy.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmitEasy.API.Controllers
{
    [Route("api/nfse")]
    [ApiController]
    public class NfseController: ControllerBase
    {
        private readonly INfseRepositorio _nfseRepositorio;
        private readonly IServicoEvento _servicoEvento;

        public NfseController(INfseRepositorio nfseRepositorio, IServicoEvento servicoEvento)
        {
            _nfseRepositorio = nfseRepositorio;
            _servicoEvento = servicoEvento;
        }

        [HttpPost("enviaNfse")]
        public IActionResult EnviaNfse(Guid id)
        {
            _servicoEvento.EnviarEvento(id);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var listaNfse = _nfseRepositorio.GetAll();
            return Ok(listaNfse);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var notafical = _nfseRepositorio.GetById(id);

            if (notafical == null) return NotFound();

            return Ok(notafical);
        }

        [HttpPost]
        public IActionResult Insert(NotaFiscalServico notaFiscal)
        {
            _nfseRepositorio.Insert(notaFiscal);

            return CreatedAtAction(nameof(GetById), new { id = notaFiscal.Id }, notaFiscal);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, NotaFiscalServico input)
        {
            var NfseExiste = _nfseRepositorio.Update(id, input);

            if (!NfseExiste) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var NfseExiste = _nfseRepositorio.Delete(id);

            if (!NfseExiste) return NotFound();

            return NoContent();
        }
    }
}
