using Automoviles.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Automoviles.DataAccess
{
    public class AutoDbContext : DbContext
    {

        public AutoDbContext( DbContextOptions<AutoDbContext> options ) : base(options)
        {

        }

        protected override void OnModelCreating( ModelBuilder builder )
        {


            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            //optionsBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog = SMSAsignaciones; Integrated Security = true");


            //optionsBuilder.UseSqlServer(@"Server=sbadesa017;Database=ACADEMY_NET_ANTO;User Id = net_anto; Password=Academy_2022");
            //optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=Auto_Motion; Trusted_Connection=True"); // DB_LOCAL-PC_JOSE_CASA

            //comentar OnConfiguring  cuando  se configure en BASE del constructor
        }

        public DbSet<Color> Colores { get; set; }
        public DbSet<Combustible> Combustibles { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Transmision> Transmisiones { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}


/*
 NOTA

Una vez tenemos el contexto creado en nuestro proyecto, iremos a la «Consola del Administrador de paquetes», 
y ahí dispondremos de estos comandos:

add-migration {nombre} -Context {contexto}
remove-migration
update-database {nombre} -Context {contexto}
drop-database -Context {contexto}
 
*/