using AutoMapper;
using AutoMotion.Repositories.UoW;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Automoviles.Models.Entities;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Implements
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UsuarioService> _logger;

        public UsuarioService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            ILogger<UsuarioService> logger
            )
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task Delete( int id )
        {
            await _unitOfWork.Usuarios.Delete(id);
            await _unitOfWork.SaveChanges();
        }

        public async Task<IEnumerable<UsuarioDTO>> GetAll()
        {
            var result = await _unitOfWork.Usuarios.GetAll();
            return _mapper.Map<IEnumerable<UsuarioDTO>>(result);
        }

        public async Task<UsuarioDTO> GetById( int id )
        {
            var resultado = await _unitOfWork.Usuarios.GetById(id);
            return _mapper.Map<UsuarioDTO>(resultado);
        }

        public async Task<UsuarioDTO> Insert( UsuarioDTO model )
        {
            var entity = _mapper.Map<Usuario>(model);
            var resultado = await _unitOfWork.Usuarios.Insert(entity);
            return _mapper.Map<UsuarioDTO>(resultado);
        }

        public async Task<UsuarioDTO> Update( UsuarioDTO model )
        {
            var entity = _mapper.Map<Usuario>(model);
            var resultado = await _unitOfWork.Usuarios.Update(entity);
            return _mapper.Map<UsuarioDTO>(resultado);
        }
    }
}
