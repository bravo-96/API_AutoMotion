using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class ModeloRepository : IModeloRepository
    {
        private readonly AutoDbContext _context;

        public ModeloRepository( AutoDbContext context )
        {
            _context = context;
        }

        public async Task Delete( int id )
        {
            var modelo = await GetById(id);

            if( modelo != null )
            {
                _context.Modelos.Remove(modelo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Modelo>> GetAll()
        {
            return await _context.Modelos.ToListAsync();
        }

        public async Task<Modelo> GetById( int id )
        {
            return await _context.Modelos.FindAsync(id);
        }

        public async Task<Modelo> Insert( Modelo model )
        {
            await _context.Modelos.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Modelo> Update( Modelo model )
        {
            _context.Modelos.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
