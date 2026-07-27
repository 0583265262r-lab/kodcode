using DutyLogAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DutyLogAPI.Data
{
    
    public class DutyLogsData 
    {
        public static List<DutyLog> dutyLogs = new()
        
        
            {
                new DutyLog
                {
                    Id = 1,
                    Name = "Avi",
                    StationName = "American Airlines",
                    ShiftStart = DateTime.UtcNow.AddHours(1),
                    Remarks = "Morning shift"
                },
                new DutyLog
                {
                    Id = 2,
                    Name = "David",
                    StationName = "Delta Airlines",
                    ShiftStart = DateTime.UtcNow.AddHours(3),
                    Remarks = "On time"
                },
                new DutyLog
                {
                    Id = 3,
                    Name = "Moshe",
                    StationName = "Lufthansa",
                    ShiftStart = DateTime.UtcNow.AddHours(5),
                    Remarks = "Night shift"
                },
                new DutyLog
                {
                    Id = 4,
                    Name = "Yossi",
                    StationName = "El Al",
                    ShiftStart = DateTime.UtcNow.AddHours(7),
                    Remarks = "Training"
                },
                new DutyLog
                {
                    Id = 5,
                    Name = "Shlomo",
                    StationName = "United Airlines",
                    ShiftStart = DateTime.UtcNow.AddHours(9),
                    Remarks = "Standby"
                }
            };

    }
}
  
         
    

