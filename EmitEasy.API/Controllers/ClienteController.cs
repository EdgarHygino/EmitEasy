using EmitEasy.Models.Entities;
using EmitEasy.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmitEasy.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var clientes = _clienteRepositorio.GetAll();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var cliente = _clienteRepositorio.GetById(id);

            if (cliente == null) return NotFound();

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Insert(Cliente cliente)
        {
            _clienteRepositorio.Insert(cliente);

            return CreatedAtAction(nameof(GetById), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Cliente imput)
        {
            var clienteExiste = _clienteRepositorio.Update(id, imput);

            if (!clienteExiste) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var clienteExiste = _clienteRepositorio.Delete(id);

            if (!clienteExiste) return NotFound();

            return NoContent();
        }
    }
}
