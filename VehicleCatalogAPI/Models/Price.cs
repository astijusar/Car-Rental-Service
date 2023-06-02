using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleCatalogAPI.Models
{
    public class Price
    {
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "decimal(10, 2)")]
        public decimal Hour { get; set; }


        [Column(TypeName = "decimal(10, 2)")]
        public decimal Day { get; set; }


        [Column(TypeName = "decimal(10, 2)")]
        public decimal Week { get; set; }


        public int CarId { get; set; }
        public Car Car { get; set; } = null!;
    }
}
