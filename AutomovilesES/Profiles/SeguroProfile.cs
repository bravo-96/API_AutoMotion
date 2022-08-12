using AutoMapper;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;

namespace Automoviles.Models.Profiles
{
    public class SeguroProfile : Profile
    {
        public SeguroProfile()
        {
            CreateMap<Seguro, SeguroDTO>()
                .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                .ForMember(destino => destino.Nombre, option => option.MapFrom(origen => origen.Nombre))
                .ReverseMap();
        }
    }
}