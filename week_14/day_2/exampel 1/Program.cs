using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    public class Report
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public string Zone { get; set; }
        public int SignalStrength { get; set; }
        public string Shift { get; set; }
        public Report(int id, string category, int priority, string zone, int signalStrength, string shift)
        {
            Id = id;
            Category = category;
            Priority = priority;
            Zone = zone;
            SignalStrength = signalStrength;
            Shift = shift;
        }

        static void Main()
        {
            string back = File.ReadAllText("reports.json");
            List<Report> reports = JsonSerializer.Deserialize<List<Report>>(back)??new();
            //Console.WriteLine(back);
            int total = reports.Count(); // how many reports
            Console.WriteLine(total);
            var idsSignals = reports
                  .Where(r => r.Category == "SIGNAL")
                  .Select(r => r.Id).ToList();
            //foreach (var id in idsSignals)
            //    Console.WriteLine(id);
            var idsPriority = reports
                  .Where(r => r.Priority >= 4)
                  .Select(r => r.Id).ToList();
            //Console.WriteLine(string.Join(", ", idsPriority));
            //foreach(var id in idsPriority)
            //    Console.WriteLine(id);
            var idsNightShift = reports
                 .Where(r => r.Shift == "Night")
                 .Where(r=> r.Zone == "North")
                 .Select(r => r.Id).ToList();
            var idAndPriority = reports
                .Where(r=> r.Category == "COMMS")
                .Select(r => new { r.Id, r.Priority }).ToList();
            Console.WriteLine(idAndPriority);
            //foreach(var id in idAndPriority)
            //    Console.WriteLine(id);
            var idofPriority = reports
                .OrderByDescending(r => r.Priority)
                .Select(r => new { r.Id, r.Priority }).ToList();
            //Console.WriteLine(string.Join(", ", idofPriority));
            var byZoneThenPriority = reports
                 .OrderBy(r => r.Zone)
                 .ThenByDescending(r => r.Priority)
                 .Select(r => new {r.Id ,r.Zone,r.Priority});
            //Console.WriteLine(string.Join(", ", byZoneThenPriority));
            var topSignalStrength = reports
                .OrderByDescending(r => r.SignalStrength)
                .Take(3)
                .Select(r => new {r.Id,r.SignalStrength}).ToList();
            //Console.WriteLine(string.Join(", ", topSignalStrength));
            var SkipTop5Priority = reports
                .OrderByDescending(r => r.Priority)
                .Skip(5)
                .Select(r => r.Id);
            //Console.WriteLine(string.Join(", ", SkipTop5Priority));
            var countPriority5 = reports
                .GroupBy(r=> r.Priority == 5)
                .Count()









            int urgent = reports.Count(r => r.Priority >= 4); // how many match
            double avgSignal = reports.Average(r => r.SignalStrength); //mean of a field
            int strongest = reports.Max(r => r.SignalStrength); //largest value
            int weakest = reports.Min(r => r.SignalStrength); //smallest value
            int prioritySum = reports.Sum(r => r.Priority); //total of a field
            bool anyCritical = reports.Any(r => r.Priority == 5); // at least one?
            bool allReadable = reports.All(r => r.SignalStrength >= 40); //every single one?
            var zones = reports.Select(r => r.Zone).Distinct();
        }
    }
}
