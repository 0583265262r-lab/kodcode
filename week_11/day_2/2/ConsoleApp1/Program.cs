using System;
using System.Diagnostics;

namespace Demo;
class Toolsi
{
    static void Main()
    {
        AddTrack("32", 305.88);
        AddTrack("909", 84.0);
        AddTrack("37", 34.8);
        Console.WriteLine(AverageSpeed());
        List<string> fast = FastTracks(300);
        Console.WriteLine($"{fast.Count} fast tracks");
    }
    static List<string> track = new List<string>();
    static List<double> speeds = new List<double>();

    static void AddTrack(string id, double speed)
    {
        track.Add(id);
        speeds.Add(speed);
    }
    static double AverageSpeed()
    {
        if (speeds.Count == 0) return 0.0;
        double sum = 0;
        foreach (double s in speeds) sum += s;
        return sum / speeds.Count;


    }
    static List<string> FastTracks(double treshold)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < track.Count; i++)
        {
            if (speeds[i] > treshold)
                result.Add(track[i]);
        }
        return result;
    }


}