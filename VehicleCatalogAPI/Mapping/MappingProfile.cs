using AutoMapper;
using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.Models.DTOs;

namespace VehicleCatalogAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>()
                .ForMember(
                    dest => dest.Extras,
                    opt => opt.MapFrom(src => src.CarExtras.Select(e => e.Extra.Name))
                );

            CreateMap<Extra, ExtraDto>();

            CreateMap<CarExtra, CarExtraDto>();
        }
    }
}
