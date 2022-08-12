using Automoviles.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface IModeloService
    {
        Task<ModeloDTO> Insert( ModeloDTO model );
        Task<ModeloDTO> Update( ModeloDTO model );
        Task Delete( int id );
        Task<IEnumerable<ModeloDTO>> GetAll();
        Task<ModeloDTO> GetById( int id );
    }
}
