using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly AutoDbContext _context;

        public VehiculoRepository( AutoDbContext context )
        {
            _context = context;
        }
        public async Task Delete( int id )
        {
            var vehiculo = await GetById(id);

            if( vehiculo != null )
            {
                _context.Vehiculos.Remove(vehiculo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Vehiculo>> GetAll()
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

        public async Task<Vehiculo> GetById( int id )
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

        public async Task<Vehiculo> Insert( Vehiculo model )
        {
            await _context.Vehiculos.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Vehiculo> Update( Vehiculo model )
        {
            _context.Vehiculos.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
