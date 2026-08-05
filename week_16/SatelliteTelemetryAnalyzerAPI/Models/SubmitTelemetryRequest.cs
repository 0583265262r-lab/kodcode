using System.ComponentModel.DataAnnotations;
namespace SatelliteTelemetryAnalyzerAPI.Models
{
    public class SubmitTelemetryRequest
    {
        [Required]
        public int SatelliteId { get; set; }
        [Required]
        [Range(0,100)]
        public int BatteryPercent { get; set; }
        [Required]
        [Range(-100,100)]
        public int TemperatureCelsius { get; set; }
        [Required]
        [Range(-120,0)]
        public int SignalStrengthDb { get; set; }
    }
}
