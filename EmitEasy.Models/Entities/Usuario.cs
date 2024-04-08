using Microsoft.AspNetCore.Identity;

namespace EmitEasy.Models.Entities
{
    public class Usuario: IdentityUser
    {
        public DateTime DataNascimento { get; set; }

        public Usuario(): base(){}
    }
}
