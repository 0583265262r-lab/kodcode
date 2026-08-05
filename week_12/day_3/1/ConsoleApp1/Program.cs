class Track : IComparable<Track> // promise: I can be compared to another Track
{
    public int Id { get; }
    public double Speed { get; }
    public Track(int id, double speed) { Id = id; Speed = speed; }
    public int CompareTo(Track other) // the framework calls this to sort
    => Speed.CompareTo(other.Speed); // order by speed (ascending)
    public override string ToString() => $"Track {Id}: {Speed} kn";
    static List<Track> all()
    {
        List<Track> tracks = new()
        {
            new Track(1, 420), new Track(2, 90), new Track(3, 250)
        };
        //tracks.Sort(); // uses CompareTo — no sorting code of your own
        foreach (Track t in tracks) Console.WriteLine(t);
        return tracks;
    }
    static void Main()
    {
        all();
    }
}

