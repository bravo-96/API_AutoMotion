using AutoMapper;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;

namespace Automoviles.Models.Profiles
{
    public class VehiculoProfile : Profile
    {
        public VehiculoProfile()
        {
            CreateMap<Vehiculo, VehiculoDTO>()
                .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                .ForMember(destino => destino.Modelo, option => option.MapFrom(origen => origen.Modelo))
                .ForMember(destino => destino.ModeloId, option => option.MapFrom(origen => origen.ModeloId))
                .ForMember(destino => destino.Pais, option => option.MapFrom(origen => origen.Pais))
                .ForMember(destino => destino.PaisId, option => option.MapFrom(origen => origen.PaisId))
                .ForMember(destino => destino.Color, option => option.MapFrom(origen => origen.Color))
                .ForMember(destino => destino.ColorId, option => option.MapFrom(origen => origen.ColorId))
                .ForMember(destino => destino.Combustible, option => option.MapFrom(origen => origen.Combustible))
                .ForMember(destino => destino.CombustibleId, option => option.MapFrom(origen => origen.CombustibleId))
                .ForMember(destino => destino.Seguro, option => option.MapFrom(origen => origen.Seguro))
                .ForMember(destino => destino.SeguroId, option => option.MapFrom(origen => origen.SeguroId))
                .ForMember(destino => destino.Tipo, option => option.MapFrom(origen => origen.Tipo))
                .ForMember(destino => destino.TipoId, option => option.MapFrom(origen => origen.TipoId))
                .ForMember(destino => destino.Precio, option => option.MapFrom(origen => origen.Precio))
                .ForMember(destino => destino.Anio, option => option.MapFrom(origen => origen.Anio))
                .ForMember(destino => destino.Marca, option => option.MapFrom(origen => origen.Marca))
                .ForMember(destino => destino.MarcaId, option => option.MapFrom(origen => origen.MarcaId))
                .ReverseMap();
        }
    }
}