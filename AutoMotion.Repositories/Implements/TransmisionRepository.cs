using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class TransmisionRepository : ITransmisionRepository
    {
        private readonly AutoDbContext _context;

        public TransmisionRepository( AutoDbContext context )
        {
            _context = context;
        }
        public async Task Delete( int id )
        {
            var transmision = await GetById(id);

            if( transmision != null )
            {
                _context.Transmisiones.Remove(transmision);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Transmision>> GetAll()
        {
            return await _context.Transmisiones.ToListAsync();
        }

        public async Task<Transmision> GetById( int id )
        {
            return await _context.Transmisiones.FindAsync(id);
        }

        public async Task<Transmision> Insert( Transmision model )
        {
            await _context.Transmisiones.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Transmision> Update( Transmision model )
        {
            _context.Transmisiones.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
