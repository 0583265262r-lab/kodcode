using SatelliteTelemetryAnalyzerAPI.Models;
using SatelliteTelemetryAnalyzerAPI.Enums;

namespace SatelliteTelemetryAnalyzerAPI.Data
{
        public class SatelliteData
        {
            public List<Satellite> Satellites = new()
        {
            new Satellite
            {
                Id = 1,
                Name = "Horizon-1",
                OrbitAltitudeKm = 550,
                Status = Status.Active
            },
            new Satellite
            {
                Id = 2,
                Name = "SkyWatch-A",
                OrbitAltitudeKm = 1200,
                Status = Status.Standby
            },
            new Satellite
            {
                Id = 3,
                Name = "GeoLink-5",
                OrbitAltitudeKm = 35786,
                Status = Status.Active
            },
            new Satellite
            {
                Id = 4,
                Name = "Explorer-X",
                OrbitAltitudeKm = 800,
                Status = Status.Decommissioned
            },
            new Satellite
            {
                Id = 5,
                Name = "Orbiter-9",
                OrbitAltitudeKm = 20000,
                Status = Status.Standby
            }
        };
        }
    }

