using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface ITipoRepository
    {
        Task<Tipo> Insert( Tipo model );
        Task<Tipo> Update( Tipo model );
        Task Delete( int id );
        Task<IEnumerable<Tipo>> GetAll();
        Task<Tipo> GetById( int id );
    }
}
