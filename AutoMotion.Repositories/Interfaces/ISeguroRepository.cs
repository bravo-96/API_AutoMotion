using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface ISeguroRepository
    {
        Task<Seguro> Insert( Seguro model );
        Task<Seguro> Update( Seguro model );
        Task Delete( int id );
        Task<IEnumerable<Seguro>> GetAll();
        Task<Seguro> GetById( int id );
    }
}
