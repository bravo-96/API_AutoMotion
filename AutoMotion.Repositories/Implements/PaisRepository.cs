using AutoMotion.Repositories.Generic;
using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;

namespace AutoMotion.Repositories.Implements
{
    public class PaisRepository : GenericRepository<Pais>, IPaisRepository
    {
        public PaisRepository( AutoDbContext context ) : base(context) { }
    }
}
