using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface IModeloRepository
    {
        Task<Modelo> Insert( Modelo model );
        Task<Modelo> Update( Modelo model );
        Task Delete( int id );
        Task<IEnumerable<Modelo>> GetAll();
        Task<Modelo> GetById( int id );
    }
}
