namespace SatelliteTelemetryAnalyzerAPI.Exceptions
{
    public class CriticalTelemetryException :Exception
    {
        public int SatelliteId { get; }
        public string Reason;
        public CriticalTelemetryException(int satelliteId, string reason)
            : base($"Critical telemetry error for satellite {satelliteId}: {reason}")
        {
            SatelliteId = satelliteId;
            Reason = reason;
        }
    }
}
