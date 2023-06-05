using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VehicleCatalogAPI.Models.Configuration
{
    public class ExtraConfiguration : IEntityTypeConfiguration<Extra>
    {
        public void Configure(EntityTypeBuilder<Extra> builder)
        {
            builder.HasData
            (
                new Extra
                {
                    Id = 1,
                    Name = "GPS"
                },
                new Extra
                {
                    Id = 2,
                    Name = "AC"
                },
                new Extra
                {
                    Id = 3,
                    Name = "Heated seats"
                },
                new Extra
                {
                    Id = 4,
                    Name = "Autopilot"
                }
            );
        }
    }
}
