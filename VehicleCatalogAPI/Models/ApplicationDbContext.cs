using Microsoft.EntityFrameworkCore;

namespace VehicleCatalogAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Extra> Extras { get; set; } = null!;
        public DbSet<Price> Prices { get; set; } = null!;
        public DbSet<CarExtra> CarExtras { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarExtra>().HasKey(ce => new { ce.CarId, ce.ExtraId });

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Price)
                .WithOne(p => p.Car)
                .HasForeignKey<Price>(p => p.CarId);
        }
    }
}
