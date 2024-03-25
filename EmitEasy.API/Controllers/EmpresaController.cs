using EmitEasy.Infra.Dados.Context;
using EmitEasy.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace EmitEasy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly EmitEasyDbContext _context;

        public EmpresaController(EmitEasyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var empresas = _context.Empresa.Where(e => !e.Ativo).ToList();
            return Ok(empresas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var empresa = _context.Empresa
                    .SingleOrDefault(e => e.Id == id);

            if (empresa == null) return NotFound();

            return Ok(empresa);
        }

        [HttpPost]
        public IActionResult Insert(EmpresaModel empresa)
        {
            _context.Empresa.Add(empresa);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = empresa.Id }, empresa);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, EmpresaModel imput)
        {
            var empresa = _context.Empresa.SingleOrDefault(d => d.Id == id);

            if (empresa == null) return NotFound();

            empresa.Update(imput.RazaoSocial, imput.NomeFantasia, imput.InscricaoEstadual, imput.InscricaoMunicial, imput.Nome,
            imput.Descricao, imput.Email, imput.Telefone, imput.Celular, imput.Cep, imput.Rua, imput.Numero, imput.Cidade, imput.Pais,
            imput.Bairro, imput.Estado, imput.Complemento, imput.CodMunicipio);

            _context.Empresa.Update(empresa);
            _context.SaveChanges();
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var empresa = _context.Empresa.SingleOrDefault(d => d.Id == id);

            if (empresa == null) return NotFound();

            empresa.Delete();
            _context.SaveChanges();
            return NoContent();
        }
    }
}
