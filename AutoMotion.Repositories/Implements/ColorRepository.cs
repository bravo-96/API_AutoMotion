using AutoMotion.Repositories.Generic;
using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;

namespace AutoMotion.Repositories.Implements
{
    public class ColorRepository : GenericRepository<Color>, IColorRepository
    {
        public ColorRepository( AutoDbContext context ) : base(context)
        {

        }
    }
}
