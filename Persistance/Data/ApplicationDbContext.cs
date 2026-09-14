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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Soap", Description= "A solid bar of soap. Safe for skin."},
                new Product { Id = 2, Name = "Candy", Description = "A choclolate bar." },
                new Product { Id = 3, Name = "Shampoo", Description = "A bottle of shampoo for cleaning hair." }
                );
        }
    }
}
