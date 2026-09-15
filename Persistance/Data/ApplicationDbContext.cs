using Microsoft.EntityFrameworkCore;
using GetTheRepsWeb.Persistance.Models;

namespace GetTheRepsWeb.Persistance.Data
{
    // This class represents the session with the database so that i can query and command instances of my database entities
    public class ApplicationDbContext : DbContext
    {
        // from program cs, when we setup EF, we will initialize this class so that we can use EF through this class
        // it is an instance of DbContext, and the options will represent the connections strings to the database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }

    }
}
