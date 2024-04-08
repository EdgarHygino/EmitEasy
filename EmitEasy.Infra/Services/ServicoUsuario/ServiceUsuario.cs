using AutoMapper;
using EmitEasy.Models.Dtos;
using EmitEasy.Models.Entities;
using EmitEasy.Models.Interfaces.Services.ServicoUsuario;
using Microsoft.AspNetCore.Identity;

namespace EmitEasy.Infra.Services.ServicoUsuario
{
    public class ServiceUsuario : IServicoUsuario
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;
        private TokenService _tokenService;

        public ServiceUsuario(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task CadastrarUsuario(CreateUserDto createUserDto)
        {
            var usuario = _mapper.Map<Usuario>(createUserDto);

            IdentityResult resultado = await _userManager.CreateAsync(usuario, createUserDto.Password);

            if (!resultado.Succeeded)
                throw new ApplicationException("Falha ao Cadastrar Usuário!");

        }

        public async Task<string> Login(LoginUsuarioDto loginUsuarioDto)
        {
            var resutado = await _signInManager.PasswordSignInAsync(loginUsuarioDto.UserName,
                loginUsuarioDto.Password, false, false);

            if (!resutado.Succeeded)
            {
                throw new ApplicationException("Usuário não autenticado!");
            }

            var usuario = _signInManager
                .UserManager
                .Users
                .FirstOrDefault(user => user.NormalizedUserName == loginUsuarioDto.UserName.ToUpper());

            var token = _tokenService.GenerateToken(usuario);

            return token;
        }
    }
}
