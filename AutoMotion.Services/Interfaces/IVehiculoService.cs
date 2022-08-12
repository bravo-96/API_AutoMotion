using Automoviles.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface IVehiculoService
    {
        Task<VehiculoDTO> Insert( VehiculoDTO model );
        Task<VehiculoDTO> Update( VehiculoDTO model );
        Task Delete( int id );
        Task<IEnumerable<VehiculoDTO>> GetAll();
        Task<VehiculoDTO> GetById( int id );
    }
}
