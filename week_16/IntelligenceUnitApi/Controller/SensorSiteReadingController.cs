using Microsoft.AspNetCore.Mvc;
using IntelligenceUnitApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
namespace IntelligenceUnitApi.Controller
{
    [ApiController]
    [Route("api/Controller")]
    public class SensorSiteReadingController:ControllerBase
    {
        private static readonly List<SensorSiteReading> _readings = new()
        {
            new SensorSiteReading
            {
                Id = 1,
                SiteName = "Alpha",
                Zone = "North",
                Status = "Active",
                TimeOfLastContact = DateTime.Parse("2026-07-26 10:30:00")
            },

            new SensorSiteReading
            {
                Id = 2,
                SiteName = "Beta",
                Zone = "West",
                Status = "Silent",
                TimeOfLastContact = DateTime.Parse("2026-07-25 10:30:00")
            },

            new SensorSiteReading
            {
                Id = 3,
                SiteName = "Gamma",
                Zone = "West",
                Status = "Active",
                TimeOfLastContact = DateTime.Parse("2026-04-25 10:30:00")
            },
            new SensorSiteReading
            {
                Id = 4,
                SiteName = "Delta",
                Zone = "West",
                Status = "Silent",
                TimeOfLastContact = DateTime.Parse("2026-06-25 11:39:00")

            },
            new SensorSiteReading
            {
                Id = 5,
                SiteName = "Epsilon",
                Zone = "East",
                Status = "Silent",
                TimeOfLastContact = DateTime.Parse("2026-06-25 11:39:00")

            }
        };
     
        [HttpGet]
        public ActionResult<IEnumerable<SensorSiteReading>> GetAllReadings()
        {
            return Ok(_readings);
        }
        [HttpGet("{id}")]
        public ActionResult<SensorSiteReading> GetAllReadings(int id)
        {
            var reading = _readings.FirstOrDefault(r => r.Id == id);
            if (reading == null)
            {
                return NotFound();
            }
            return Ok(reading);
        }
        [HttpGet("zone")]
        public ActionResult<IEnumerable<SensorSiteReading>> GetReadingsByZone([FromQuery] string? zone)
        {
            var query = _readings.AsEnumerable();
            if (zone != null)
            {
                query = query.Where(r =>
            r.Zone.Equals(zone,
    StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return Ok(query.ToList());
        }
        [HttpGet("search")]
        public ActionResult<IEnumerable<SensorSiteReading>> GetReadingsByQuery(
            [FromQuery] int? id,
            [FromQuery] string? zone,
            [FromQuery] DateTime? timeOfLastContact)
        {
            var query = _readings.AsEnumerable();
            if (id.HasValue)
            {
                query = query.Where(r => r.Id == id);
            }
            if(zone != null)
            {
                query = query.Where(r =>
            r.Zone.Equals(zone,
    StringComparison.OrdinalIgnoreCase));
            }
            if (timeOfLastContact.HasValue)
            {
                query = query.Where(r => r.TimeOfLastContact >= DateTime.Parse("2026-06-25 11:39:00"));
            }
            return Ok(query);
        }



    }
}
