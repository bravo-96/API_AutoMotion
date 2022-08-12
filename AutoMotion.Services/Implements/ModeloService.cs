using AutoMapper;
using AutoMotion.Repositories.Interfaces;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Implements
{
    public class ModeloService : IModeloService
    {
        private readonly IMapper _mapper;
        private readonly IModeloRepository _ModeloRepository;
        public ModeloService( IMapper mapper, IModeloRepository ModeloRepository )
        {
            _mapper = mapper;
            _ModeloRepository = ModeloRepository;
        }

        public async Task Delete( int id )
        {
            await _ModeloRepository.Delete(id);
        }

        public async Task<IEnumerable<ModeloDTO>> GetAll()
        {
            var resultado = await _ModeloRepository.GetAll();
            return _mapper.Map<IEnumerable<ModeloDTO>>(resultado);
        }

        public async Task<ModeloDTO> GetById( int id )
        {
            var resultado = await _ModeloRepository.GetById(id);
            return _mapper.Map<ModeloDTO>(resultado);
        }

        public async Task<ModeloDTO> Insert( ModeloDTO model )
        {
            var entity = _mapper.Map<Modelo>(model);
            var resultado = await _ModeloRepository.Insert(entity);
            return _mapper.Map<ModeloDTO>(resultado);
        }

        public async Task<ModeloDTO> Update( ModeloDTO model )
        {
            var entity = _mapper.Map<Modelo>(model);
            var resultado = await _ModeloRepository.Update(entity);
            return _mapper.Map<ModeloDTO>(resultado);
        }
    }
}
