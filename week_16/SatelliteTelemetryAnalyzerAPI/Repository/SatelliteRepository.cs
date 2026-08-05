using SatelliteTelemetryAnalyzerAPI.Models;
using SatelliteTelemetryAnalyzerAPI.Data;

namespace SatelliteTelemetryAnalyzerAPI.Repository
{
    
    public class SatelliteRepository:ISatelliteRepository
    {
        private readonly List<Satellite> _satellites;

        public SatelliteRepository()
        {
            SatelliteData data = new SatelliteData();
            _satellites = data.Satellites;
        }
        private int _nextId = 6;
        public async Task<IEnumerable<Satellite>> GetAllAsync()
        {
            await Task.Delay(10);
            return _satellites;
        }

        public async Task<Satellite?> GetByIdAsync(int id)
        {
            await Task.Delay(10);
            return _satellites.FirstOrDefault(s => s.Id == id);
        }
        public async Task<Satellite> CreateAsync(Satellite satellite)
        {
            await Task.Delay(10);
            satellite.Id = _nextId++;
            _satellites.Add(satellite);
            return satellite;

            
        }
        public async Task<Satellite?> UpdateAsync(int id, Satellite satellite)
        {
            await Task.Delay(10);
            var existing = _satellites.FirstOrDefault(s => s.Id == id);
            if (existing == null)
            {
                return null;
            }
            existing.Name = satellite.Name;
            existing.OrbitAltitudeKm = satellite.OrbitAltitudeKm;
            existing.Status = satellite.Status;
            return existing;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(10);
            var deleted = _satellites.FirstOrDefault(s => s.Id == id);
            if (deleted == null)
            {
                return false;
            }
            _satellites.Remove(deleted);
            return true;
        }


    }
}
