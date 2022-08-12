using AutoMapper;
using AutoMotion.Repositories.Interfaces;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Implements
{
    public class PaisService : IPaisService
    {
        private readonly IMapper _mapper;
        private readonly IPaisRepository _PaisRepository;
        public PaisService( IMapper mapper, IPaisRepository PaisRepository )
        {
            _mapper = mapper;
            _PaisRepository = PaisRepository;
        }

        public async Task Delete( int id )
        {
            await _PaisRepository.Delete(id);
        }

        public async Task<IEnumerable<PaisDTO>> GetAll()
        {
            var resultado = await _PaisRepository.GetAll();
            return _mapper.Map<IEnumerable<PaisDTO>>(resultado);
        }

        public async Task<PaisDTO> GetById( int id )
        {
            var resultado = await _PaisRepository.GetById(id);
            return _mapper.Map<PaisDTO>(resultado);
        }

        public async Task<PaisDTO> Insert( PaisDTO model )
        {
            var entity = _mapper.Map<Pais>(model);
            var resultado = await _PaisRepository.Insert(entity);
            return _mapper.Map<PaisDTO>(resultado);
        }

        public async Task<PaisDTO> Update( PaisDTO model )
        {
            var entity = _mapper.Map<Pais>(model);
            var resultado = await _PaisRepository.Update(entity);
            return _mapper.Map<PaisDTO>(resultado);
        }
    }
}
