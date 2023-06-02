using VehicleCatalogAPI.Models.Enums;

namespace VehicleCatalogAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int Year { get; set; }
        public CarType Type { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public Transmission Transmission { get; set; }
        public double Power { get; set; }
        public bool Electric { get; set; }

        public Price Price { get; set; } = null!;
        public ICollection<CarExtra> CarExtras { get; set; } = null!;
    }
}
