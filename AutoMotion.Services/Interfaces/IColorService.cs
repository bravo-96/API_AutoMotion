using Automoviles.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface IColorService
    {
        Task<ColorDTO> Insert( ColorDTO model );
        Task<ColorDTO> Update( ColorDTO model );
        Task Delete( int id );
        Task<IEnumerable<ColorDTO>> GetAll();
        Task<ColorDTO> GetById( int id );
    }
}
