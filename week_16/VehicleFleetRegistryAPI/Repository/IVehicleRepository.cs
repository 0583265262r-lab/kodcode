using Microsoft.AspNetCore.Http.HttpResults;
using VehicleFleetRegistryAPI.Enums;
using VehicleFleetRegistryAPI.Models;

namespace VehicleFleetRegistryAPI.Repository
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();
        int GetNextId();
        Vehicle? GetById(int id);
        Vehicle? GetByRegistrationNumber(string regNumber);
        IEnumerable<Vehicle> GetByStatus(Status status);
        IEnumerable<Vehicle> GetByType(string vehicleType);
        Vehicle Create(Vehicle vehicle);
        Vehicle? Update(int id, Vehicle vehicle);
        bool Delete(int id);
    }
}
