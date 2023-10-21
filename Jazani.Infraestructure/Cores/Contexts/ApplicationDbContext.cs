using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Jazani.Infraestructure.Cores.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }



        //#region "DbSet"
        //public DbSet<Office> Offices { get; set; }
        //public DbSet<MineralType> MineralTypes { get; set; }
        //#endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Aplica la configuracio en toda la aplicación
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Aplica la configuracion mas detallada.
            //modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            //modelBuilder.ApplyConfiguration(new MineralTypeConfiguration());
        }
    }
}
