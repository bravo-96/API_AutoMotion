//using Automoviles.DataAccess;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using AutoMotion.Repositories.Interfaces;
//using AutoMotion.Repositories.Implements;
//using AutoMotion.Repositories.UoW;

//namespace AutoMotion.Repositories.Support
//{
//    public static class DatabaseExtension
//    {
//        /// <summary>
//        /// Metodo extensivo para la configuracion de la base de datos
//        /// </summary>
//        /// <param name="services"></param>
//        /// <param name="Configuration"></param>
//        /// <returns></returns>
//        public static IServiceCollection AddCustomizedDatabase( this IServiceCollection services, IConfiguration Configuration )
//        {
//            #region Unit Of Work
//            services.AddTransient<IUnitOfWork, UnitOfWork>();
//            #endregion

//            #region DbContext
//            services.AddDbContext<AutoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AutoMotionDB"),
//                  b => b.MigrationsAssembly("AutoMotion.API")));

//            #endregion

//            #region Repositories
//            services.AddTransient<IAgrupadorRepository, AgrupadorRepository>();
//            services.AddTransient<IColaboradorRepository, ColaboradorRepository>();
//            services.AddTransient<IDetalleEvaluacionRepository, DetalleEvaluacionRepository>();
//            services.AddTransient<IEvaluacionRepository, EvaluacionRepository>();
//            services.AddTransient<IFactorRepository, FactorRepository>();
//            services.AddTransient<IGrupoRepository, GrupoRepository>();
//            services.AddTransient<IPonderacionRepository, PonderacionRepository>();
//            services.AddTransient<IResultadoRepository, ResultadoRepository>();
//            services.AddTransient<ITipoEvaluacionRepository, TipoEvaluacionRepository>();
//            services.AddTransient<ITipoCredencialRepository, TipoCredencialRepository>();
//            services.AddTransient<ICredencialRepository, CredencialRepository>();

//            #endregion
//            return services;
//        }
//    }
//}
