using Microsoft.AspNetCore.Http.HttpResults;
using SatelliteTelemetryAnalyzerAPI.Models;

namespace SatelliteTelemetryAnalyzerAPI.Repository
{
    public interface ITelemetryRepository
    {
        Task<IEnumerable<TelemetryReport>>GetAllAsync();
        Task<TelemetryReport?> GetByIdAsync(int id);
        Task<IEnumerable<TelemetryReport>> GetBySatelliteIdAsync(int satelliteId);
        Task<TelemetryReport?> CreateAsync(TelemetryReport report);
    }
}
