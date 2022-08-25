using AutoMotion.Repositories.Generic;
using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;

namespace AutoMotion.Repositories.Implements
{
    public class TipoRepository : GenericRepository<Tipo>, ITipoRepository
    {
        public TipoRepository( AutoDbContext context ) : base(context) { }
    }
}
