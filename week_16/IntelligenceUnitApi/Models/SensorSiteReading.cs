using System.Xml.Linq;

namespace IntelligenceUnitApi.Models
{
    public class SensorSiteReading
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string Zone { get; set; }
        public string Status { get; set; }
        public DateTime TimeOfLastContact { get; set; }
    }
}
