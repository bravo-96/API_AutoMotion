using AutoMotion.Repositories.Generic;
using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;

namespace AutoMotion.Repositories.Implements
{
    public class SeguroRepository : GenericRepository<Seguro>, ISeguroRepository
    {
        public SeguroRepository( AutoDbContext context ) : base(context) { }
    }
}
