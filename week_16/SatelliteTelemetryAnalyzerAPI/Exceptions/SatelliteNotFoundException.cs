namespace SatelliteTelemetryAnalyzerAPI.Exceptions
{
    public class SatelliteNotFoundException: Exception
    {
        public int SatelliteId { get; }
        public SatelliteNotFoundException(int satelliteId)
            :base($"The Satellite {satelliteId} not found.")
        {
            SatelliteId = satelliteId;
        }
    }
}
