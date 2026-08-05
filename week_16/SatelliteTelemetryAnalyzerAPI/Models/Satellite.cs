using SatelliteTelemetryAnalyzerAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace SatelliteTelemetryAnalyzerAPI.Models
{
    public class Satellite
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(200,40000)]
        public int OrbitAltitudeKm { get; set; }
        [Required]
        public Status Status { get; set; }

    }
}
