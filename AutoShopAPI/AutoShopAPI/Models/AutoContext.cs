using Microsoft.EntityFrameworkCore;

namespace AutoShopAPI.Models
{
    public class AutoContext : DbContext
    {
        public AutoContext(DbContextOptions<AutoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(c => c.Cars)
                .WithOne(a => a.Manufacturer)
                .HasForeignKey(a => a.ManufacturerId);

            modelBuilder.Seed();
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}
