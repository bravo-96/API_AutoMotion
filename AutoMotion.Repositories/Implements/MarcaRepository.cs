using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly AutoDbContext _context;

        public MarcaRepository( AutoDbContext context )
        {
            _context = context;
        }

        public async Task Delete( int id )
        {
            var marca = await GetById(id);

            if( marca != null )
            {
                _context.Marcas.Remove(marca);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Marca>> GetAll()
        {
            return await _context.Marcas.ToListAsync();
        }

        public async Task<Marca> GetById( int id )
        {
            return await _context.Marcas.FindAsync(id);
        }

        public async Task<Marca> Insert( Marca model )
        {
            await _context.Marcas.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Marca> Update( Marca model )
        {
            _context.Marcas.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
