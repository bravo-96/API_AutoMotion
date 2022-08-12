using AutoMapper;
using AutoMotion.Repositories.Interfaces;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Implements
{
    public class ColorService : IColorService
    {
        private readonly IMapper _mapper;
        private readonly IColorRepository _ColorRepository;
        public ColorService( IMapper mapper, IColorRepository ColorRepository )
        {
            _mapper = mapper;
            _ColorRepository = ColorRepository;
        }

        public async Task Delete( int id )
        {
            await _ColorRepository.Delete(id);
        }

        public async Task<IEnumerable<ColorDTO>> GetAll()
        {
            var resultado = await _ColorRepository.GetAll();
            return _mapper.Map<IEnumerable<ColorDTO>>(resultado);
        }

        public async Task<ColorDTO> GetById( int id )
        {
            var resultado = await _ColorRepository.GetById(id);
            return _mapper.Map<ColorDTO>(resultado);
        }

        public async Task<ColorDTO> Insert( ColorDTO model )
        {
            var entity = _mapper.Map<Color>(model);
            var resultado = await _ColorRepository.Insert(entity);
            return _mapper.Map<ColorDTO>(resultado);
        }

        public async Task<ColorDTO> Update( ColorDTO model )
        {
            var entity = _mapper.Map<Color>(model);
            var resultado = await _ColorRepository.Update(entity);
            return _mapper.Map<ColorDTO>(resultado);
        }
    }
}
