using Microsoft.EntityFrameworkCore;
using Stores.Shared.Entities;
// Esta clase debe estar en todos los proyectos
namespace Stores.API.Data
{
    public class DataContext: DbContext  //Para implementarn con la DataContext  que tiene C# internamente
    {
        //Constructor de la clase DataContext
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }
        
        //Instrucción para señalar una tabla (DbSet) <nombre de la entidad>
        public DbSet<Country> Countries { get; set; }

        //Permite mandar la entidad 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();

        }
    }

    

}
