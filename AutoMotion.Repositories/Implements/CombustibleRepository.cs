using AutoMotion.Repositories.Generic;
using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;

namespace AutoMotion.Repositories.Implements
{
    public class CombustibleRepository : GenericRepository<Combustible>, ICombustibleRepository
    {
        public CombustibleRepository( AutoDbContext context ) : base(context) { }
    }
}
