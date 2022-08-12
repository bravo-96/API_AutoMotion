using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface ICombustibleRepository
    {
        Task<Combustible> Insert( Combustible model );
        Task<Combustible> Update( Combustible model );
        Task Delete( int id );
        Task<IEnumerable<Combustible>> GetAll();
        Task<Combustible> GetById( int id );
    }
}