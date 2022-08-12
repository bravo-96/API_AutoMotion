using Automoviles.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface IMarcaService
    {
        Task<MarcaDTO> Insert( MarcaDTO model );
        Task<MarcaDTO> Update( MarcaDTO model );
        Task Delete( int id );
        Task<IEnumerable<MarcaDTO>> GetAll();
        Task<MarcaDTO> GetById( int id );
    }
}
