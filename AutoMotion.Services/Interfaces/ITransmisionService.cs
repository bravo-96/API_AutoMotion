using Automoviles.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface ITransmisionService
    {
        Task<TransmisionDTO> Insert( TransmisionDTO model );
        Task<TransmisionDTO> Update( TransmisionDTO model );
        Task Delete( int id );
        Task<IEnumerable<TransmisionDTO>> GetAll();
        Task<TransmisionDTO> GetById( int id );
    }
}
