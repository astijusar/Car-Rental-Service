using VehicleCatalogAPI.Models.Enums;

namespace VehicleCatalogAPI.RequestFeatures
{
    public class CarRequestParameters : RequestParameters
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? YearMin { get; set; } = int.MinValue;
        public int? YearMax { get; set; } = int.MaxValue;
        public string? Color { get; set; }
        public CarType? Type { get; set; }
        public Transmission? Transmission { get; set; }
        public int? Seats { get; set; }
        public int? Doors { get; set; }
        public double? PowerMin { get; set; } = double.MinValue;
        public double? PowerMax { get; set; } = double.MaxValue;
        public bool? Electric { get; set; }
    }
}
