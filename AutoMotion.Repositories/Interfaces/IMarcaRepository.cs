using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface IMarcaRepository
    {
        Task<Marca> Insert( Marca model );
        Task<Marca> Update( Marca model );
        Task Delete( int id );
        Task<IEnumerable<Marca>> GetAll();
        Task<Marca> GetById( int id );
    }
}
