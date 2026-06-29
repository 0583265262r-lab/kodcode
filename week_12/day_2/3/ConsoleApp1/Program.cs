using Demo;
using System;
namespace Demo;

abstract class Track // abstract: a Track "in general" cannot exist
{
public int Id { get; }
public double Speed { get; set; }
protected Track(int id, double speed) // base constructor for derived classes
    {
        Id = id;
        Speed = speed;
    }
public abstract string Describe(); // no body — every kind MUST implement it
}
class Aircraft : Track
{
    public double Altitude { get; }
    public Aircraft(int id, double speed, double altitude)
    : base(id, speed) => Altitude = altitude;
    public override string Describe()
    => $"Aircraft {Id} at {Altitude} ft, {Speed} kn";
}
class Vessel : Track
{
    public Vessel(int id, double speed) : base(id, speed) { }
    public override string Describe()
    => $"Vessel {Id}, {Speed} kn";
    static void Main()
    {
        Aircraft a = new Aircraft(3, 2525.2, 2532.5);
        Console.WriteLine(a.Describe());
        Vessel v = new Vessel(5, 653.4);
        Console.WriteLine(v.Describe());

    }
}
