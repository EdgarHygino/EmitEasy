using AutoMapper;
using EmitEasy.Models.Dtos;
using EmitEasy.Models.Entities;

namespace EmitEasy.API.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUserDto, Usuario>();
        }
    }
}
