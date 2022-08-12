using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class TipoRepository : ITipoRepository
    {
        private readonly AutoDbContext _context;

        public TipoRepository( AutoDbContext context )
        {
            _context = context;
        }
        public async Task Delete( int id )
        {
            var tipo = await GetById(id);

            if( tipo != null )
            {
                _context.Tipos.Remove(tipo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Tipo>> GetAll()
        {
            return await _context.Tipos.ToListAsync();
        }

        public async Task<Tipo> GetById( int id )
        {
            return await _context.Tipos.FindAsync(id);
        }

        public async Task<Tipo> Insert( Tipo model )
        {
            await _context.Tipos.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Tipo> Update( Tipo model )
        {
            _context.Tipos.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
