using AutoMotion.Repositories.Generic;
using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;

namespace AutoMotion.Repositories.Implements
{
    public class ModeloRepository : GenericRepository<Modelo>, IModeloRepository
    {
        public ModeloRepository( AutoDbContext context ) : base(context) { }
    }
}
