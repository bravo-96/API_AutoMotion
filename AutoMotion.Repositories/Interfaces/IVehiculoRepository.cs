using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface IVehiculoRepository
    {
        Task<Vehiculo> Insert( Vehiculo model );
        Task<Vehiculo> Update( Vehiculo model );
        Task Delete( int id );
        Task<IEnumerable<Vehiculo>> GetAll();
        Task<Vehiculo> GetById( int id );
    }
}
