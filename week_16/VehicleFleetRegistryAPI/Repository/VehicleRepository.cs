using VehicleFleetRegistryAPI.Models;
using VehicleFleetRegistryAPI.Data;
using VehicleFleetRegistryAPI.Enums;
using Microsoft.AspNetCore.Mvc;

namespace VehicleFleetRegistryAPI.Repository
{
    public class VehicleRepository :IVehicleRepository
    {
        private readonly List<Vehicle> _vehicles;

        public VehicleRepository()
        {
            VehicleData vehicleData = new VehicleData();
            _vehicles = vehicleData.vehicles;
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _vehicles;
        }
        public int GetNextId()
        {
            return GetAll().Max(l => l.Id) + 1; 
        }

        public Vehicle? GetById(int id)
        {
            return _vehicles.FirstOrDefault(v => v.Id == id);
        }
        public Vehicle? GetByRegistrationNumber(string regNumber)
        {
            return _vehicles.FirstOrDefault(v => v.RegistrationNumber == regNumber);
        }
        public IEnumerable<Vehicle> GetByStatus(Status status)
        {
            return _vehicles.Where(v => v.Status == status).ToList();
        }

        public IEnumerable<Vehicle> GetByType(string vehicleType)
        {
            return _vehicles.Where(v => v.VehicleType == vehicleType);
        }
        public Vehicle Create(Vehicle vehicle)
        {
            vehicle.Id = GetNextId();
            _vehicles.Add(vehicle);
            return vehicle;
        }

        public Vehicle? Update(int id, Vehicle vehicle)
        {
            var updatedVehicle = GetById(id);
            if (updatedVehicle == null)
            {
                return null;
            }
            updatedVehicle.RegistrationNumber = vehicle.RegistrationNumber;
            updatedVehicle.VehicleType = vehicle.VehicleType;
            updatedVehicle.Status = vehicle.Status;
            updatedVehicle.AssignedDriver = vehicle.AssignedDriver;
            updatedVehicle.CurrentLocation = vehicle.CurrentLocation;
            updatedVehicle.Mileage = vehicle.Mileage;
            return updatedVehicle;
        }
        public bool Delete(int id)
        {
            var vehicle = GetById(id);
            if (vehicle == null)
            { return false; }
            _vehicles.Remove(vehicle);
            return true;

           
        }

    }
}
