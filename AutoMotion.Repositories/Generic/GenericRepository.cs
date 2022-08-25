using Automoviles.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        internal AutoDbContext _context;
        internal DbSet<T> dbSet;

        ///////////////////////////////////////////////////////////

        public GenericRepository( AutoDbContext context )
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public async Task<T> Delete( int id )
        {
            var model = await GetById(id);

            if( model != null )
            {
                dbSet.Remove(model);
                await _context.SaveChangesAsync();
            }
            return model;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetById( int id )
        {
            var model = await dbSet.FindAsync(id);
            return model;
        }

        public async Task<T> Insert( T model )
        {
            await dbSet.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<T> Update( T model )
        {
            dbSet.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
