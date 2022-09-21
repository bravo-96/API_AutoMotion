using AutoMotion.Repositories.Interfaces;
using Automoviles.DataAccess;
using System.Threading.Tasks;

namespace AutoMotion.Repositories.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Dependencias

        private readonly AutoDbContext _context;

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
        #endregion

        #region Constructor
        public UnitOfWork(
            AutoDbContext context,
            IColorRepository colores,
            ICombustibleRepository combustibles,
            IMarcaRepository marcas,
            IModeloRepository modelos,
            IPaisRepository paises,
            ISeguroRepository seguros,
            ITipoRepository tipos,
            ITransmisionRepository transmisiones,
            IUsuarioRepository usuarios,
            IVehiculoRepository vehiculos
            )
        {
            _context = context;

            Colores = colores;
            Combustibles = combustibles;
            Marcas = marcas;
            Modelos = modelos;
            Paises = paises;
            Seguros = seguros;
            Tipos = tipos;
            Transmisiones = transmisiones;
            Usuarios = usuarios;
            Vehiculos = vehiculos;
        }
        #endregion

        #region Metodos

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        #endregion
    }
}
