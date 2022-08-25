using AutoMotion.Repositories.Generic;
using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;

namespace AutoMotion.Repositories.Implements
{
    public class TransmisionRepository : GenericRepository<Transmision>, ITransmisionRepository
    {
        public TransmisionRepository( AutoDbContext context ) : base(context) { }
    }
}
