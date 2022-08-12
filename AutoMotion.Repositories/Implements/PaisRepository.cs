using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class PaisRepository : IPaisRepository
    {
        private readonly AutoDbContext _context;

        public PaisRepository( AutoDbContext context )
        {
            _context = context;
        }

        public async Task Delete( int id )
        {
            var pais = await GetById(id);

            if( pais != null )
            {
                _context.Paises.Remove(pais);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Pais>> GetAll()
        {
            return await _context.Paises.ToListAsync();
        }

        public async Task<Pais> GetById( int id )
        {
            return await _context.Paises.FindAsync(id);
        }

        public async Task<Pais> Insert( Pais model )
        {
            await _context.Paises.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Pais> Update( Pais model )
        {
            _context.Paises.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
