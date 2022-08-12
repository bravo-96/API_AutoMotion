using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class SeguroRepository : ISeguroRepository
    {
        private readonly AutoDbContext _context;

        public SeguroRepository( AutoDbContext context )
        {
            _context = context;
        }
        public async Task Delete( int id )
        {
            var seguro = await GetById(id);

            if( seguro != null )
            {
                _context.Seguros.Remove(seguro);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Seguro>> GetAll()
        {
            return await _context.Seguros.ToListAsync();
        }

        public async Task<Seguro> GetById( int id )
        {
            return await _context.Seguros.FindAsync(id);
        }

        public async Task<Seguro> Insert( Seguro model )
        {
            await _context.Seguros.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Seguro> Update( Seguro model )
        {
            _context.Seguros.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
