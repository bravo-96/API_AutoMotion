using Automoviles.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface ITipoService
    {
        Task<TipoDTO> Insert( TipoDTO model );
        Task<TipoDTO> Update( TipoDTO model );
        Task Delete( int id );
        Task<IEnumerable<TipoDTO>> GetAll();
        Task<TipoDTO> GetById( int id );
    }
}
