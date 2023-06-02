using System.ComponentModel.DataAnnotations;

namespace VehicleCatalogAPI.Models
{
    public class Extra
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<CarExtra> CarExtras { get; set; } = null!;
    }
}
