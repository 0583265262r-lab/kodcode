using SatelliteTelemetryAnalyzerAPI.Models;

namespace SatelliteTelemetryAnalyzerAPI.Repository
{
    public class TelemetryRepository: ITelemetryRepository
    {
        private readonly List<TelemetryReport> _telemetryReport = new();
        private int _nextId = 1;
        public async Task<IEnumerable<TelemetryReport>> GetAllAsync()
        {
            await Task.Delay(10);
            return _telemetryReport;
        }
        public async Task<TelemetryReport?> GetByIdAsync(int id)
        {
            await Task.Delay(10);
            return _telemetryReport.FirstOrDefault(t => t.Id == id);
        }
        public async Task<IEnumerable<TelemetryReport>> GetBySatelliteIdAsync(int satelliteId)
        {
            await Task.Delay(10);
            return _telemetryReport.Where(t => t.SatelliteId == satelliteId).ToList();
        }
        public async Task<TelemetryReport> CreateAsync(TelemetryReport report)
        {
            await Task.Delay(10);
            report.Id = _nextId;
            _telemetryReport.Add(report);
            return report;
        }
    }
}
