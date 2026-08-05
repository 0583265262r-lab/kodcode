namespace WeatherStationApi.Models
{
    public class WeatherReading
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public string Location { get; set; }
        public double TemperatureCelsius { get; set; }
        public int HumidityPercent { get; set; }
        public double WindSpeedKmh { get; set; }
        public DateTime RecordedAt { get; set; }

    }
}
