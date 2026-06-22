using System;
namespace Exmplel;
class Track
{
    static void Main()
    {

    }
    static List<string> FastTracks(double treshold)
    {
        List<string> result = new List<string>;
        for (int i = 0; i< Track.Count; i++)
        {
            if (speeds[i] > treshold)
                result.Add(Track[i]);
        }
        return result;
    }
}

