using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using VehicleCatalogAPI.Models.Enums;

namespace VehicleCatalogAPI.Models.DTOs
{
    public class CarDto
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public string Transmission { get; set; }
        public double Power { get; set; }
        public bool Electric { get; set; }
        public decimal Hour { get; set; }
        public decimal Day { get; set; }
        public decimal Week { get; set; }
        public IEnumerable<string> Extras { get; set; }
    }
}
