using AutoMotion.Repositories.Generic;
using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Implements
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository( AutoDbContext context ) : base(context)
        {

        }

        public async Task<Usuario> GetByNombre( string nombre )
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Nombre.ToLower() == nombre.ToLower());
        }
    }
}
