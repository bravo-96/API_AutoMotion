using AutoMotion.Repositories.Generic;
using Automoviles.Models.Entities;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Task<Usuario> GetByNombre( string nombre );
    }
}
