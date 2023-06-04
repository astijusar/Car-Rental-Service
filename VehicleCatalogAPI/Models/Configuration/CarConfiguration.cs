using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleCatalogAPI.Models.Enums;

namespace VehicleCatalogAPI.Models.Configuration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            var faker = new Faker();            
            var cars = new List <Car>();

            for (int i = 1; i <= 20; i++)
            {
                cars.Add(new Car
                {
                    Id = i,
                    Make = faker.Vehicle.Manufacturer(),
                    Model = faker.Vehicle.Model(),
                    Color = faker.Commerce.Color(),
                    Year = faker.Random.Int(1980, 2023),
                    Type = faker.PickRandom<CarType>(),
                    Seats = faker.Random.Int(2, 8),
                    Doors = faker.PickRandom(2, 4),
                    Transmission = faker.PickRandom<Transmission>(),
                    Power = faker.Random.Int(50, 1000),
                    Electric = faker.Random.Bool(),
                    Hour = faker.Random.Decimal(1.0m, 20.0m),
                    Day = faker.Random.Decimal(10.0m, 50.0m),
                    Week = faker.Random.Decimal(100.0m, 300.0m)
                });
            }

            builder.HasData(cars);
        }
    }
}
