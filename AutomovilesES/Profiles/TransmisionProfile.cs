using AutoMapper;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;

namespace Automoviles.Models.Profiles
{
    public class TransmisionProfile : Profile
    {
        public TransmisionProfile()
        {
            CreateMap<Transmision, TransmisionDTO>()
                .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                .ForMember(destino => destino.Nombre, option => option.MapFrom(origen => origen.Nombre))
                .ReverseMap();
        }
    }
}