using Microsoft.AspNetCore.Mvc;
using DutyLogAPI.Data;
using DutyLogAPI.Models;

namespace DutyLogAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class DutyLogsControllers: ControllerBase
    {
        public readonly List<DutyLog> _dutyLogs = DutyLogsData.dutyLogs;
        
        private int _nextId = 6;
        [HttpGet]
        public ActionResult<IEnumerable<DutyLog>> GetAllFlightLogs()
        {
            return Ok(_dutyLogs);
        }
        [HttpGet("{id}")]
        public ActionResult<DutyLog>GetDutyLogById(int id)
        {
            var log = _dutyLogs.FirstOrDefault(r => r.Id == id);
            if (log == null)
            {
                return NotFound();
            }
            return Ok(log);
        }
 
        [HttpPost]
        public ActionResult<DutyLog>CreateDutyLog(DutyLog dutyLog)
        {
            dutyLog.Id = _nextId++;
            _dutyLogs.Add(dutyLog);
            return CreatedAtAction(
            nameof(GetDutyLogById),
            new { id = dutyLog.Id },
            dutyLog);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateDutyLog(int id,DutyLog updateDutyLog)
        {
            var existingLog = _dutyLogs.FirstOrDefault(l => l.Id == id);
            if (existingLog == null)
            {
                return NotFound();
            }
            existingLog.StationName = updateDutyLog.StationName;
            existingLog.ShiftStart = updateDutyLog.ShiftStart;
            existingLog.ShiftEnd = updateDutyLog.ShiftEnd;
            existingLog.Remarks = updateDutyLog.Remarks;
            return NoContent();        
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDutyLodById(int id)
        {
            var log = _dutyLogs.FirstOrDefault(l => l.Id == id);
            if (log == null)
            {
                return NotFound();
            }
            _dutyLogs.Remove(log);
            return NoContent();
        }
    }
}
