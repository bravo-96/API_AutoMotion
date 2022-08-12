using AutoMapper;
using AutoMotion.Repositories.Interfaces;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Implements
{
    public class TransmisionService : ITransmisionService
    {
        private readonly IMapper _mapper;
        private readonly ITransmisionRepository _TransmisionRepository;
        public TransmisionService( IMapper mapper, ITransmisionRepository TransmisionRepository )
        {
            _mapper = mapper;
            _TransmisionRepository = TransmisionRepository;
        }

        public async Task Delete( int id )
        {
            await _TransmisionRepository.Delete(id);
        }

        public async Task<IEnumerable<TransmisionDTO>> GetAll()
        {
            var resultado = await _TransmisionRepository.GetAll();
            return _mapper.Map<IEnumerable<TransmisionDTO>>(resultado);
        }

        public async Task<TransmisionDTO> GetById( int id )
        {
            var resultado = await _TransmisionRepository.GetById(id);
            return _mapper.Map<TransmisionDTO>(resultado);
        }

        public async Task<TransmisionDTO> Insert( TransmisionDTO model )
        {
            var entity = _mapper.Map<Transmision>(model);
            var resultado = await _TransmisionRepository.Insert(entity);
            return _mapper.Map<TransmisionDTO>(resultado);
        }

        public async Task<TransmisionDTO> Update( TransmisionDTO model )
        {
            var entity = _mapper.Map<Transmision>(model);
            var resultado = await _TransmisionRepository.Update(entity);
            return _mapper.Map<TransmisionDTO>(resultado);
        }
    }
}
