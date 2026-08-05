using Microsoft.AspNetCore.Mvc;
using VehicleFleetRegistryAPI.Models;
using VehicleFleetRegistryAPI.Repository;
using VehicleFleetRegistryAPI.Enums;

namespace VehicleFleetRegistryAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class VehicleFleetRegistryController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleFleetRegistryController(IVehicleRepository vehicle)
        {
            _vehicleRepository = vehicle;
        }
        [HttpGet("all-vehicles")]
        public ActionResult<IEnumerable<Vehicle>> GetAll()
        {
            var vehicles = _vehicleRepository.GetAll();
            return Ok(vehicles);
        }
        [HttpGet("{id}")]
        public ActionResult<Vehicle>GetById(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle == null)
                return NotFound();
            return Ok(vehicle);        
        }
        [HttpGet("registration/{regNumber}")]
        public ActionResult<Vehicle> GetByRegistrationNumber(string regNumber)
        {
            var vehicle = _vehicleRepository.GetByRegistrationNumber(regNumber);
            if (vehicle == null)
                return NotFound();
            return Ok(vehicle);
        }
        [HttpGet("status")]
        public ActionResult<IEnumerable<Vehicle>>GetByStatus([FromQuery] string status)
        {
            bool convertString = Enum.TryParse<Status>(status, true, out Status result);
            var vehicle = _vehicleRepository.GetByStatus(result);
            return Ok(vehicle);
        }
        [HttpGet("type")]
        public ActionResult<IEnumerable<Vehicle>>GetByType([FromQuery] string vehicleType)
        {
            var vehicle = _vehicleRepository.GetByType(vehicleType);
            return Ok(vehicle);
        }
        [HttpPost("create-vehicle")]
        public ActionResult<Vehicle>CreateVehicle(Vehicle vehicle)
        {
            var NewVehicle = _vehicleRepository.Create(vehicle);
            return CreatedAtAction(nameof(GetById), new { id = NewVehicle.Id }, NewVehicle);
        }
        [HttpPut("vehicles/{id}")]
        public ActionResult<Vehicle> UpdateVehicle(int id, Vehicle vehicle)
        {
            var updated = _vehicleRepository.Update(id, vehicle);
            if (updated == null)
                return NotFound();
            return NoContent();
        }
        [HttpDelete("vehicles/{id}")]
        public ActionResult<Vehicle>DeleteVehicle(int id)
        {
            var vehicle = _vehicleRepository.Delete(id);
            if (!vehicle)
            { return NotFound(); }
            return NoContent();
        }
    }
}
