using AutoMapper;
using AutoMotion.Repositories.Interfaces;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Implements
{
    public class SeguroService : ISeguroService
    {
        private readonly IMapper _mapper;
        private readonly ISeguroRepository _SeguroRepository;
        public SeguroService( IMapper mapper, ISeguroRepository SeguroRepository )
        {
            _mapper = mapper;
            _SeguroRepository = SeguroRepository;
        }

        public async Task Delete( int id )
        {
            await _SeguroRepository.Delete(id);
        }

        public async Task<IEnumerable<SeguroDTO>> GetAll()
        {
            var resultado = await _SeguroRepository.GetAll();
            return _mapper.Map<IEnumerable<SeguroDTO>>(resultado);
        }

        public async Task<SeguroDTO> GetById( int id )
        {
            var resultado = await _SeguroRepository.GetById(id);
            return _mapper.Map<SeguroDTO>(resultado);
        }

        public async Task<SeguroDTO> Insert( SeguroDTO model )
        {
            var entity = _mapper.Map<Seguro>(model);
            var resultado = await _SeguroRepository.Insert(entity);
            return _mapper.Map<SeguroDTO>(resultado);
        }

        public async Task<SeguroDTO> Update( SeguroDTO model )
        {
            var entity = _mapper.Map<Seguro>(model);
            var resultado = await _SeguroRepository.Update(entity);
            return _mapper.Map<SeguroDTO>(resultado);
        }
    }
}
