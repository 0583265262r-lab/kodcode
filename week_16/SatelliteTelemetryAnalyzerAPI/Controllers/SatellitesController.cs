using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SatelliteTelemetryAnalyzerAPI.Models;
using SatelliteTelemetryAnalyzerAPI.Repository;
using System.Threading.Tasks;

namespace SatelliteTelemetryAnalyzerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SatellitesController: ControllerBase
    {
        private readonly ISatelliteRepository _satelliteRepository;
        public SatellitesController(ISatelliteRepository satelliteRepository)
        {
            _satelliteRepository = satelliteRepository;
        }
        [HttpGet("all-satellite")]
        public async Task<ActionResult<IEnumerable<Satellite>>>GetAll()
        {
            return Ok(await _satelliteRepository.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Satellite>>GetById(int id)
        {
            var satellite = await _satelliteRepository.GetByIdAsync(id);
            if (satellite == null)
                return NotFound();
            return Ok(satellite);
        }
        [HttpPost]
        public async Task<ActionResult<Satellite>>CreateSatellite(Satellite satellite)
        {
            var create = await _satelliteRepository.CreateAsync(satellite);
            return CreatedAtAction(nameof(GetById), new { id = create.Id }, create);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Satellite>>UpdateSatellite(int id , Satellite satellite)
        {
            var updated = await _satelliteRepository.UpdateAsync(id, satellite);
            if (updated == null)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Satellite>>DeleteById(int id)
        {
            var deleted = await _satelliteRepository.DeleteAsync(id);
            if (! deleted)
                return NotFound();
            return NoContent();
        }

    }
}
