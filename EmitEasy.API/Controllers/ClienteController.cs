using EmitEasy.Infra.Dados.Context;
using EmitEasy.Models.Entities;
using EmitEasy.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmitEasy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly EmitEasyDbContext _context;

        public ClienteController(EmitEasyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var empresas = _context.Cliente.Where(e => !e.Ativo).ToList();
            return Ok(empresas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var empresa = _context.Cliente
                    .SingleOrDefault(e => e.Id == id);

            if (empresa == null) return NotFound();

            return Ok(empresa);
        }

        [HttpPost]
        public IActionResult Insert(ClienteModel cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, ClienteModel imput)
        {
            var cliente = _context.Cliente.SingleOrDefault(d => d.Id == id);

            if (cliente == null) return NotFound();

            cliente.Update(imput.RazaoSocial, imput.NomeFantasia, imput.InscricaoEstadual, imput.InscricaoMunicial, imput.Nome,
            imput.Descricao, imput.Email, imput.Telefone, imput.Celular, imput.Cep, imput.Rua, imput.Numero, imput.Cidade, imput.Pais,
            imput.Bairro, imput.Estado, imput.Complemento, imput.CodMunicipio);

            _context.Cliente.Update(cliente);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var cliente = _context.Cliente.SingleOrDefault(d => d.Id == id);

            if (cliente == null) return NotFound();

            cliente.Delete();
            _context.SaveChanges();
            return NoContent();
        }
    }
}
