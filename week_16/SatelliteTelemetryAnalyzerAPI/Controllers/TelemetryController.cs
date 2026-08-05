using Microsoft.AspNetCore.Mvc;
using SatelliteTelemetryAnalyzerAPI.Services;
using SatelliteTelemetryAnalyzerAPI.Models;
using SatelliteTelemetryAnalyzerAPI.Exceptions;

namespace SatelliteTelemetryAnalyzerAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TelemetryController: ControllerBase
    {
        private readonly ITelemetryService _telemetryService;
        public TelemetryController(ITelemetryService telemetryService)
        {
            _telemetryService = telemetryService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TelemetryReport>>>GetAll()
        {
            return Ok(await _telemetryService.GetAllReportsAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult< TelemetryReport?>> GetReportById(int id)
        {
            var report = await _telemetryService.GetReportByIdAsync(id);
            if (report == null)
                return NotFound();
            return Ok(report);
        }
        [HttpGet("satellite/{satelliteId}")]
        public async Task<ActionResult<IEnumerable<TelemetryService>>> GetReportbySatelliteId(int satelliteId)
        {
            var reports = await _telemetryService.GetReportByIdAsync(satelliteId);
            if (reports == null)
                return NotFound();
            return Ok(reports);
        }
        [HttpPost]
        public async Task<ActionResult<TelemetryReport>>CreateReport(SubmitTelemetryRequest request)
        {
            try
            {
                var create = await _telemetryService.SubmitTelemetryAsync(request);
                return create;
            }
            catch (SatelliteNotFoundException e)
            {
                return BadRequest(e.Message);
            }
            catch(CriticalTelemetryException e)
            {
                return UnprocessableEntity(e.Message);
            }
        }



    }
}
