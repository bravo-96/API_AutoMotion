using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoMotion.Repositories.Implements
{
    public class ColorRepository : IColorRepository
    {
        private readonly AutoDbContext _context;

        public ColorRepository( AutoDbContext context )
        {
            _context = context;
        }

        public async Task Delete( int id )
        {
            var color = await GetById(id);

            if( color != null )
            {
                _context.Colores.Remove(color);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Color>> GetAll()
        {
            return await _context.Colores.ToListAsync();
        }

        public async Task<Color> GetById( int id )
        {
            return await _context.Colores.FindAsync(id);
        }

        public async Task<Color> Insert( Color model )
        {
            await _context.Colores.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Color> Update( Color model )
        {
            _context.Colores.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }

    }
}
