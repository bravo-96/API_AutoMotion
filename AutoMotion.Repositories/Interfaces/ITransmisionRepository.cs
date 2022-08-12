using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface ITransmisionRepository
    {
        Task<Transmision> Insert( Transmision model );
        Task<Transmision> Update( Transmision model );
        Task Delete( int id );
        Task<IEnumerable<Transmision>> GetAll();
        Task<Transmision> GetById( int id );
    }
}
