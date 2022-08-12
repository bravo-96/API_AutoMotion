using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface IPaisRepository
    {
        Task<Pais> Insert( Pais model );
        Task<Pais> Update( Pais model );
        Task Delete( int id );
        Task<IEnumerable<Pais>> GetAll();
        Task<Pais> GetById( int id );
    }
}
