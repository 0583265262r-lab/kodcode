using System.Text.Json.Serialization;

namespace SatelliteTelemetryAnalyzerAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        Active, Standby, Decommissioned
    }
}
