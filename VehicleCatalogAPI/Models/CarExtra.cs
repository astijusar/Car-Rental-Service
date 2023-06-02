namespace VehicleCatalogAPI.Models
{
    public class CarExtra
    {
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        public int ExtraId { get; set; }
        public Extra Extra { get; set; } = null!;
    }
}
