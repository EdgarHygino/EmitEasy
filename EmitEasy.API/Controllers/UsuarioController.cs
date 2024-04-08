using EmitEasy.Models.Dtos;
using EmitEasy.Models.Entities;
using EmitEasy.Models.Interfaces.Services.ServicoUsuario;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmitEasy.API.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IServicoUsuario _servicoUsuario;
        private SignInManager<Usuario> _signInManager;

        public UsuarioController(IServicoUsuario servicoUsuario, SignInManager<Usuario> signInManager)
        {
            _servicoUsuario = servicoUsuario;
            _signInManager = signInManager;
        }


        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastrarUsuario( CreateUserDto createUserDto)
        {
            await _servicoUsuario.CadastrarUsuario(createUserDto);

            return Ok("Usuário Cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginUsuarioDto loginUsuarioDto)
        {
            var token = await _servicoUsuario.Login(loginUsuarioDto);

            return Ok(token);
        }
    }
}
