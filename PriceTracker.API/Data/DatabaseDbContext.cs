using Microsoft.EntityFrameworkCore;
using PriceTracker.API.Models.Domain;

namespace PriceTracker.API.Data
{
    public class DatabaseDbContext : DbContext
    {
        public DatabaseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
            public DbSet<States> States { get; set; }
            public DbSet<Districts> Districts { get; set; }
            public DbSet<Categories> Categories { get; set; }
            public DbSet<Prices> Prices { get; set; }
        
    }
}
