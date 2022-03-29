using Entity_Web_App.Services.DALModels;
using Microsoft.EntityFrameworkCore;

namespace Entity_Web_App.Services
{
    public class AnimalContext : DbContext
    {
        public DbSet<Animal> Animals{ get; set; } // THIS IS MY TABLE IN ENTITTY FRAMEWORK, this will 
        // create the that looks like this class in sql.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( // your connection string goes INSIDE THIS METHOD, ALSO CHANGE THE INITIAL CATALOG TO YOUR DATABASE
             @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=Animal;Integrated Security=True");
        }
    }
}
