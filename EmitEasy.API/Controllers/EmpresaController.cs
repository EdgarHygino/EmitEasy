using EmitEasy.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using EmitEasy.Models.Interfaces;

namespace EmitEasy.API.Controllers
{
    [Route("api/empresa")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        
        private readonly IEmpresaRepositorio _empresaRepositorio;

        public EmpresaController(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var empresas = _empresaRepositorio.GetAll();

            return Ok(empresas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var empresa = _empresaRepositorio.GetById(id);

            if (empresa == null) return NotFound();

            return Ok(empresa);
        }

        [HttpPost]
        public IActionResult Insert(Empresa empresa)
        {
            _empresaRepositorio.Insert(empresa);

            return CreatedAtAction(nameof(GetById), new { id = empresa.Id }, empresa);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Empresa imput)
        {
            var ExisteEmpresa = _empresaRepositorio.Update(id, imput);

            if (!ExisteEmpresa) return NotFound();

                       
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var ExisteEmpresa = _empresaRepositorio.Delete(id);

            if (!ExisteEmpresa) return NotFound();

            return NoContent();
        }
    }
}
