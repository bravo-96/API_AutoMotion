using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface IColorRepository
    {
        Task<Color> Insert( Color model );
        Task<Color> Update( Color model );
        Task Delete( int id );
        Task<IEnumerable<Color>> GetAll();
        Task<Color> GetById( int id );
    }
}