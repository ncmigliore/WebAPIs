using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AutoShopAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Vin { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        [Required]
        public int ManufacturerId { get; set; }
        [JsonIgnore]
        public virtual Manufacturer? Manufacturer { get; set; }
    }
}
