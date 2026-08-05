using System;
namespace Demo;

class Track
{
    public int Id { get; }
    public double Speed { get; set; }
    public Track(int id, double speed)
    {
        Id = id;
        Speed = speed;
    }
}
class Aircraft : Track // Aircraft IS-A Track
{
    public double Altitude { get; }
    public Aircraft(int id, double speed, double altitude)
    : base(id, speed) // build the Track part first
    {
        Altitude = altitude; // then the part unique to Aircraft
    }
    static void Main()
    {
        Aircraft a = new Aircraft(1, 420, 30000);
        Console.WriteLine($"id: {a.Id} | speed: {a.Speed} | altitude: {a.Altitude}");
    }
}