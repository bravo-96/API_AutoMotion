using AutoMapper;
using AutoMotion.Repositories.Interfaces;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Implements
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IMapper _mapper;
        private readonly IVehiculoRepository _VehiculoRepository;
        public VehiculoService( IMapper mapper, IVehiculoRepository VehiculoRepository )
        {
            _mapper = mapper;
            _VehiculoRepository = VehiculoRepository;
        }

        public async Task Delete( int id )
        {
            await _VehiculoRepository.Delete(id);
        }

        public async Task<IEnumerable<VehiculoDTO>> GetAll()
        {
            var resultado = await _VehiculoRepository.GetAll();
            return _mapper.Map<IEnumerable<VehiculoDTO>>(resultado);
        }

        public async Task<VehiculoDTO> GetById( int id )
        {
            var resultado = await _VehiculoRepository.GetById(id);
            return _mapper.Map<VehiculoDTO>(resultado);
        }

        public async Task<VehiculoDTO> Insert( VehiculoDTO model )
        {
            var entity = _mapper.Map<Vehiculo>(model);
            var resultado = await _VehiculoRepository.Insert(entity);
            return _mapper.Map<VehiculoDTO>(resultado);
        }

        public async Task<VehiculoDTO> Update( VehiculoDTO model )
        {
            var entity = _mapper.Map<Vehiculo>(model);
            var resultado = await _VehiculoRepository.Update(entity);
            return _mapper.Map<VehiculoDTO>(resultado);
        }
    }
}
