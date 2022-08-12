using Automoviles.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface ISeguroService
    {
        Task<SeguroDTO> Insert( SeguroDTO model );
        Task<SeguroDTO> Update( SeguroDTO model );
        Task Delete( int id );
        Task<IEnumerable<SeguroDTO>> GetAll();
        Task<SeguroDTO> GetById( int id );
    }
}
