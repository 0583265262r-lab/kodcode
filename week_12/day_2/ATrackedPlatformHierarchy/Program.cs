using System;
namespace ATrackedPlatformHierarchy;

abstract class Platform
{
    protected int _TrackId;
    private double _Speed { get; set; }
    private double _Heading { get; set; }
    private int trackID
    {
        set
        {
            if (value<0)
            {
                throw new ArgumentException(" the ID must by posetive");
            }
            else
            {
                _TrackId = value;
            }
        }
    }
    public int trackId { get => _TrackId; }

    public double Heading
    {
        get => _Heading;
        set
        {
            if (value> 359 || value<0)
            {
                _Heading = 0;
            }
            else
            {
                _Heading = value;
            }
        }
    }
    public double Speed
    {
        get => _Speed;
        set
        {
            if (value<0)
            {
                _Speed = 0;
            }
            else
            {
                _Speed = value;
            }
        }
    }

    protected Platform(int id, double speed, double heading)
    {
        _TrackId = id;
        Speed = speed;
        Heading = heading;
    }
    abstract public string StatusLine();
    abstract public bool IsTrackable();
    static void Main()
    {
        AllPlatforms();
        desplyeAll(AllPlatforms());
    }
    static List<Platform> AllPlatforms()
        
    {
        //AirPlatform p1 = new (1, 4, 54.5,525);
        List<Platform> allPlatforms = [];
        allPlatforms.Add(new AirPlatform(1,54.64,334,124));
        allPlatforms.Add(new AirPlatform(2, 543, 243, -324));
        allPlatforms.Add(new GroundPlatform(6, 879, 77, "ahhah"));
        allPlatforms.Add(new GroundPlatform(6, 879, 77, "tunnel"));
        allPlatforms.Add(new SeaPlatform(8, 256, 233, 234));
        allPlatforms.Add(new SeaPlatform(8, 256, 233, -234));
        return allPlatforms ;
    }
    static void desplyeAll(List<Platform> allPlatforms)
    {
        foreach (Platform p in allPlatforms)
        {
            Console.WriteLine(p.StatusLine());
            Console.WriteLine(p.IsTrackable());
        }
    }
}
class AirPlatform : Platform
{
    private double _AltitudeFeet;  
    public double AtitudeFeet
    {
        get => _AltitudeFeet;
        set
        {
            if (value<0)
            {
                _AltitudeFeet = 0;
            }
            else
            {
                _AltitudeFeet = value;
            }
        }
    }
    public AirPlatform(int id, double speed, double heading, double altitude)
        : base(id, speed, heading) => AtitudeFeet = altitude;
    public override string StatusLine()
        => $"Aircraft ID: {_TrackId} |Altitude: {_AltitudeFeet} ft |Speed: {Speed} kn |Heading {Heading} ";
    public override bool IsTrackable()
        => (AtitudeFeet >= 100 & AtitudeFeet <= 6000 & Speed > 0);
}
class GroundPlatform : Platform
{
    private string _TerrainType;
    public string TerrainType {get => _TerrainType;}
    public GroundPlatform(int id, double speed, double heading, string type)
        : base(id, speed, heading) => _TerrainType = type;
    public override string StatusLine()
        => $"sheep ID: {_TrackId} |TerrainType: {_TerrainType}  |Speed: {Speed} kn |Heading {Heading} ";
    public override bool IsTrackable()
        => (_TerrainType != "tunnel");
}
class SeaPlatform : Platform
{
    private double _DepthMeters;
    public double DepthMeters
    {
        get => _DepthMeters;
        set
        {
            if (value < 0 & value > 300)
            {
                _DepthMeters = 0;
            }
            else
            {
                _DepthMeters = value;
            }
        }
    }
    public SeaPlatform(int id, double speed, double heading, double depth)
        : base(id, speed, heading) => DepthMeters = depth;
    public override string StatusLine()
        => $"sheep ID: {_TrackId} |DepthMeters: {_DepthMeters} ft |Speed: {Speed} kn |Heading {Heading} ";
    public override bool IsTrackable()
        => (DepthMeters >= 0 & DepthMeters <= 300);
}

