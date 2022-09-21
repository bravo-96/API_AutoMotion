using Automoviles.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO> Insert( UsuarioDTO model );
        Task<UsuarioDTO> Update( UsuarioDTO model );
        Task Delete( int id );
        Task<IEnumerable<UsuarioDTO>> GetAll();
        Task<UsuarioDTO> GetById( int id );
    }
}
