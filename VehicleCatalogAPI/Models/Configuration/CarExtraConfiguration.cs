using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VehicleCatalogAPI.Models.Configuration
{
    public class CarExtraConfiguration : IEntityTypeConfiguration<CarExtra>
    {
        public void Configure(EntityTypeBuilder<CarExtra> builder)
        {
            var faker = new Faker();
            var carExtras = new List<CarExtra>();

            for (int i = 1; i <= 20; i++)
            {
                int n = faker.Random.Int(0, 4);

                if (n == 0) continue;

                for (int j = 1; j <= n; j++)
                {
                    carExtras.Add
                    (
                        new CarExtra
                        {
                            CarId = i,
                            ExtraId = j
                        }
                    );
                }
            }

            builder.HasData(carExtras);
        }
    }
}
