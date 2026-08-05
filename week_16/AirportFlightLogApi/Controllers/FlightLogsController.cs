using AirportFlightLogApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirportFlightLogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightLogsController : ControllerBase
    {
        private static readonly List<FlightLog> _flightLogs = new()
            {
                new FlightLog
                {
                Id = 1,
                FlightNumber = "AA101",
                Airline = "American Airlines",
                Destination = "New York JFK",
                PassengerCount = 180,
                ScheduledDeparture = DateTime.UtcNow.AddHours(2),
                Status = "Scheduled"
                },
                new FlightLog
                {
                Id = 2,
                FlightNumber = "BA202",
                Airline = "British Airways",
                Destination = "London Heathrow",
                PassengerCount = 250,
                ScheduledDeparture = DateTime.UtcNow.AddHours(4),
                ActualDeparture = DateTime.UtcNow.AddHours(4).AddMinutes(15),
                Status = "Departed",
                Remarks = "Delayed due to weather"
                },
                new FlightLog
                {
                Id = 3,
                FlightNumber = "LH303",
                Airline = "Lufthansa",
                Destination = "Frankfurt",
                PassengerCount = 200,
                ScheduledDeparture = DateTime.UtcNow.AddHours(6),
                Status = "Scheduled"
                }
            };
        private static int _nextId = 4;
        // GET: api/flightlogs
        [HttpGet]
        public ActionResult<IEnumerable<FlightLog>> GetAllFlightLogs()
        {
            return Ok(_flightLogs);
        }
        // GET: api/flightlogs/2
        [HttpGet("{id}")]
        public ActionResult<FlightLog> GetFlightLogById(int id)
        {
            var log = _flightLogs.FirstOrDefault(l => l.Id == id);
            if (log == null)
            {
                return NotFound();
            }
            return Ok(log);
        }
        // POST: api/flightlogs
        [HttpPost]
        public ActionResult<FlightLog> CreateFlightLog(FlightLog flightLog)
        {
            // Assign a new ID
            flightLog.Id = _nextId++;
            // Add to the list
            _flightLogs.Add(flightLog);
            // Return 201 Created with the new resource and its location
            return CreatedAtAction(
            nameof(GetFlightLogById),
            new { id = flightLog.Id },
            flightLog);
        }
        // PUT: api/flightlogs/2
        [HttpPut("{id}")]
        public IActionResult UpdateFlightLog(int id, FlightLog updatedLog)
        {
            var existingLog = _flightLogs.FirstOrDefault(l => l.Id == id);
            if (existingLog == null)
            {
                return NotFound();
            }
            // Update properties (preserve the ID from the URL)
            existingLog.FlightNumber = updatedLog.FlightNumber;
            existingLog.Airline = updatedLog.Airline;
            existingLog.Destination = updatedLog.Destination;
            existingLog.PassengerCount = updatedLog.PassengerCount;
            existingLog.ScheduledDeparture = updatedLog.ScheduledDeparture;
            existingLog.ActualDeparture = updatedLog.ActualDeparture;
            existingLog.Remarks = updatedLog.Remarks;
            existingLog.Status = updatedLog.Status;
            // Return 204 No Content (success, but no body to return)
            return NoContent();
        }
        // DELETE: api/flightlogs/2
        [HttpDelete("{id}")]
        public IActionResult DeleteFlightLog(int id)
        {
            var log = _flightLogs.FirstOrDefault(l => l.Id == id);
            if (log == null)
            {
                return NotFound();
            }
            _flightLogs.Remove(log);
            // Return 204 No Content
            return NoContent();
        }
        // GET: api/flightlogs/search?airline=American
        [HttpGet("search")]
        public ActionResult<IEnumerable<FlightLog>> SearchByAirline([FromQuery]
                string airline)
        {
            if (string.IsNullOrWhiteSpace(airline))
            {
                return BadRequest("Airline parameter cannot be empty");
            }
            var logs = _flightLogs.Where(l =>
            l.Airline.Contains(airline,
            StringComparison.OrdinalIgnoreCase)).ToList();
            return Ok(logs);
        }
    }

}

