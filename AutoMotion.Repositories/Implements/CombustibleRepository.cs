using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class CombustibleRepository : ICombustibleRepository
    {
        private readonly AutoDbContext _context;

        public CombustibleRepository( AutoDbContext context )
        {
            _context = context;
        }

        public async Task Delete( int id )
        {
            var combustible = await GetById(id);

            if( combustible != null )
            {
                _context.Combustibles.Remove(combustible);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Combustible>> GetAll()
        {
            return await _context.Combustibles.ToListAsync();
        }

        public async Task<Combustible> GetById( int id )
        {
            return await _context.Combustibles.FindAsync(id);
        }

        public async Task<Combustible> Insert( Combustible model )
        {
            await _context.Combustibles.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Combustible> Update( Combustible model )
        {
            _context.Combustibles.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
