using SatelliteTelemetryAnalyzerAPI.Models;
using System.Diagnostics;

namespace SatelliteTelemetryAnalyzerAPI.Services
{
    public interface ITelemetryService
    {
        Task<IEnumerable<TelemetryReport>> GetAllReportsAsync();
        Task<TelemetryReport?> GetReportByIdAsync(int id);
        Task<IEnumerable<TelemetryReport>> GetReportbySatelliteIdAsync(int satelliteId);
        Task<TelemetryReport> SubmitTelemetryAsync(SubmitTelemetryRequest request);

    }
}
