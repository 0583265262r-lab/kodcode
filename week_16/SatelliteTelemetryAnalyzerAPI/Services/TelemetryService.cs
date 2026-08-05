using Microsoft.AspNetCore.Http.HttpResults;
using SatelliteTelemetryAnalyzerAPI.Exceptions;
using SatelliteTelemetryAnalyzerAPI.Models;
using SatelliteTelemetryAnalyzerAPI.Repository;
using System;

namespace SatelliteTelemetryAnalyzerAPI.Services
{
    public class TelemetryService: ITelemetryService
    {
        private readonly ISatelliteRepository _satelliteRepository;
        private readonly ITelemetryRepository _telemetryRepository;
        
        public TelemetryService (ISatelliteRepository satelliteRepository, 
                                 ITelemetryRepository telemetryRepository)
        {
            _satelliteRepository = satelliteRepository;
            _telemetryRepository = telemetryRepository;
        }
        private int _nextId = 1;
        public async Task<IEnumerable<TelemetryReport>> GetAllReportsAsync()
        {
            await Task.Delay(10);
            return await _telemetryRepository.GetAllAsync();
        }
        public async Task<TelemetryReport?> GetReportByIdAsync(int id)
        {
            await Task.Delay(10);
            return await _telemetryRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<TelemetryReport>> GetReportbySatelliteIdAsync(int satelliteId)
        {
            await Task.Delay(10);
            return await _telemetryRepository.GetBySatelliteIdAsync(satelliteId);
        }
        public async Task<TelemetryReport> SubmitTelemetryAsync(SubmitTelemetryRequest request)
        {
            var satellite = _satelliteRepository.GetByIdAsync(request.SatelliteId);
            if (satellite == null)
                throw new SatelliteNotFoundException(request.SatelliteId);
            if (request.BatteryPercent < 10)
                throw new CriticalTelemetryException(request.SatelliteId, "Battery critically low.");
            if (request.TemperatureCelsius < -50 | request.TemperatureCelsius > 60)
                throw new CriticalTelemetryException(request.SatelliteId, "Temperature out of safe range");
            if (request.SignalStrengthDb < -100)
                throw new CriticalTelemetryException(request.SatelliteId, "Signal strength critically weak");
            var report = new TelemetryReport
            {
                SatelliteId = request.SatelliteId,
                BatteryPercent = request.BatteryPercent,
                TemperatureCelsius = request.TemperatureCelsius,
                SignalStrengthDb = request.SignalStrengthDb,
                ReportedAt = DateTime.Now,
                Status = "Normal"
            };
            return await _telemetryRepository.CreateAsync(report);


        }
    }
}
