using System;
namespace Demo;

class Track
{
    public int Id { get; }
    public Track(int id) { Id = id; }
    public virtual string Describe()  => $"Track {Id}"; // virtual: a derived class MAY replace it
    //static void Main()
    //{
        
    //}
}
class Aircraft : Track
{
    public double Altitude { get; }
    public Aircraft(int id, double altitude) : base(id)
    {
        Altitude = altitude;
    }
    public override string Describe() => $"Aircraft {Id} at {Altitude} ft"; // override: this kind replaces the behavior
    static void Main()
    {
        Track t = new Track(3);
        Console.WriteLine(t.Describe());
        Aircraft a = new Aircraft(1,30000);
        Console.WriteLine($"id: {a.Id} | Altitude: {a.Altitude}");
        Console.WriteLine(a.Describe());
    }
}