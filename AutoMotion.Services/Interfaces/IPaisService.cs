using Automoviles.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface IPaisService
    {
        Task<PaisDTO> Insert( PaisDTO model );
        Task<PaisDTO> Update( PaisDTO model );
        Task Delete( int id );
        Task<IEnumerable<PaisDTO>> GetAll();
        Task<PaisDTO> GetById( int id );
    }
}
