using EmitEasy.Models.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmitEasy.Infra.Services.ServicoUsuario
{
    public class TokenService
    {
        public string GenerateToken(Usuario usuario)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("username", usuario.UserName),
                new Claim("id", usuario.Id)
            };

            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jkhfw98wj238fsj3828hwejkljhsd8923"));

            var signingCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
                (
                    expires: DateTime.Now.AddHours(12),
                    claims: claims,
                    signingCredentials: signingCredentials
                );

            var retorno = new JwtSecurityTokenHandler().WriteToken(token);

            return retorno.ToString();
        }
    }
}