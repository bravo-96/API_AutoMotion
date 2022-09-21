using AutoMotion.Repositories.Interfaces;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.UoW
{
    public interface IUnitOfWork
    {
        public IColorRepository Colores { get; }
        public ICombustibleRepository Combustibles { get; }
        public IMarcaRepository Marcas { get; }
        public IModeloRepository Modelos { get; }
        public IPaisRepository Paises { get; }
        public ISeguroRepository Seguros { get; }
        public ITipoRepository Tipos { get; }
        public ITransmisionRepository Transmisiones { get; }
        public IUsuarioRepository Usuarios { get; }
        public IVehiculoRepository Vehiculos { get; }
        Task SaveChanges();
    }
}
