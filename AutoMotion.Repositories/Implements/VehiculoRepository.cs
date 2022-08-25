using AutoMotion.Repositories.Generic;
using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class VehiculoRepository : GenericRepository<Vehiculo>, IVehiculoRepository
    {

        public VehiculoRepository( AutoDbContext context ) : base(context)
        {
            _context = context;
        }

        public new async Task<IEnumerable<Vehiculo>> GetAll()
        {
            return await _context.Vehiculos
                                    .Include(x => x.Color)
                                    .Include(x => x.Combustible)
                                    .Include(x => x.Marca)
                                    .Include(x => x.Modelo)
                                    .Include(x => x.Pais)
                                    .Include(x => x.Seguro)
                                    .Include(x => x.Tipo)
                                    .Include(x => x.Transmision)
                                    .ToListAsync();
        }

        public new async Task<Vehiculo> GetById( int id )
        {
            return await _context.Vehiculos
                                    .Include(x => x.Color)
                                    .Include(x => x.Combustible)
                                    .Include(x => x.Marca)
                                    .Include(x => x.Modelo)
                                    .Include(x => x.Pais)
                                    .Include(x => x.Seguro)
                                    .Include(x => x.Tipo)
                                    .Include(x => x.Transmision)
                                    .FirstOrDefaultAsync( x => x.Id == id );
        }
    }
}
