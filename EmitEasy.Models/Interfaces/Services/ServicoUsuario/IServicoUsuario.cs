using EmitEasy.Models.Dtos;

namespace EmitEasy.Models.Interfaces.Services.ServicoUsuario
{
    public interface IServicoUsuario
    {
        Task CadastrarUsuario(CreateUserDto createUserDto);
        Task<string> Login(LoginUsuarioDto loginUsuarioDto);
    }
}
