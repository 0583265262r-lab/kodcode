using VehicleFleetRegistryAPI.Enums;
using Microsoft.AspNetCore.Razor.Hosting;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace VehicleFleetRegistryAPI.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Registration number must be between 1 and 15")]
        public string RegistrationNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string VehicleType { get; set; } = string.Empty;

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; } = Status.Available;

        [StringLength(100)]
        public string? AssignedDriver { get; set; } = string.Empty;

        [StringLength(200)]
        public string? CurrentLocation { get; set; } = string.Empty;

        [Required]
        [Range(0, 500000,ErrorMessage = "The range cannot be over then 500000 Miles")]
        public int Mileage { get; set; }
    }
}
