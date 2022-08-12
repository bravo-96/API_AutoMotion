using AutoMapper;
using AutoMotion.Repositories.Implements;
using AutoMotion.Repositories.Interfaces;
using AutoMotion.Services.Implements;
using AutoMotion.Services.Interfaces;
using Automoviles.DataAccess;
using Automoviles.Models.Profiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AutoMotion.API
{
    public class Startup
    {
        public Startup( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AutoMotion.API", Version = "v1" });
            });


            services.AddDbContext<AutoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AutoMotionDB"),
               b => b.MigrationsAssembly("ABM.Cosmico.BE.API")));

            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new ColorProfile());
                m.AddProfile(new CombustibleProfile());
                m.AddProfile(new MarcaProfile());
                m.AddProfile(new ModeloProfile());
                m.AddProfile(new PaisProfile());
                m.AddProfile(new SeguroProfile());
                m.AddProfile(new TipoProfile());
                m.AddProfile(new TransmisionProfile());
                m.AddProfile(new VehiculoProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<IColorRepository, ColorRepository>();
            services.AddTransient<ICombustibleRepository, CombustibleRepository>();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<IModeloRepository, ModeloRepository>();
            services.AddTransient<IPaisRepository, PaisRepository>();
            services.AddTransient<ISeguroRepository, SeguroRepository>();
            services.AddTransient<ITipoRepository, TipoRepository>();
            services.AddTransient<ITransmisionRepository, TransmisionRepository>();
            services.AddTransient<IVehiculoRepository, VehiculoRepository>();

            services.AddTransient<IColorService, ColorService>();
            services.AddTransient<ICombustibleService, CombustibleService>();
            services.AddTransient<IMarcaService, MarcaService>();
            services.AddTransient<IModeloService, ModeloService>();
            services.AddTransient<IPaisService, PaisService>();
            services.AddTransient<ISeguroService, SeguroService>();
            services.AddTransient<ITipoService, TipoService>();
            services.AddTransient<ITransmisionService, TransmisionService>();
            services.AddTransient<IVehiculoService, VehiculoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, IWebHostEnvironment env )
        {
            if( env.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AutoMotion.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
