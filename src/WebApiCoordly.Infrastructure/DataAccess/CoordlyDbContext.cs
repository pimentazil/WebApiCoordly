using Microsoft.EntityFrameworkCore;
using WebApiCoordly.Domain.Entities;

namespace WebApiCoordly.Infrastructure.DataAccess
{
    public class CoordlyDbContext : DbContext
    {
        public CoordlyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
