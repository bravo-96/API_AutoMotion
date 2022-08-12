using AutoMapper;
using AutoMotion.Repositories.Interfaces;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Implements
{
    public class CombustibleService : ICombustibleService
    {
        private readonly IMapper _mapper;
        private readonly ICombustibleRepository _CombustibleRepository;
        public CombustibleService( IMapper mapper, ICombustibleRepository CombustibleRepository )
        {
            _mapper = mapper;
            _CombustibleRepository = CombustibleRepository;
        }

        public async Task Delete( int id )
        {
            await _CombustibleRepository.Delete(id);
        }

        public async Task<IEnumerable<CombustibleDTO>> GetAll()
        {
            var resultado = await _CombustibleRepository.GetAll();
            return _mapper.Map<IEnumerable<CombustibleDTO>>(resultado);
        }

        public async Task<CombustibleDTO> GetById( int id )
        {
            var resultado = await _CombustibleRepository.GetById(id);
            return _mapper.Map<CombustibleDTO>(resultado);
        }

        public async Task<CombustibleDTO> Insert( CombustibleDTO model )
        {
            var entity = _mapper.Map<Combustible>(model);
            var resultado = await _CombustibleRepository.Insert(entity);
            return _mapper.Map<CombustibleDTO>(resultado);
        }

        public async Task<CombustibleDTO> Update( CombustibleDTO model )
        {
            var entity = _mapper.Map<Combustible>(model);
            var resultado = await _CombustibleRepository.Update(entity);
            return _mapper.Map<CombustibleDTO>(resultado);
        }
    }
}
