using AutoMapper;
using IdentityAPI.Models;
using IdentityAPI.Models.DTO;

namespace IdentityAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForAuthenticationDto, User>();
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
