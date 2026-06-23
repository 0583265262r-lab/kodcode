using System;
namespace Demo;
class Day3
{
    static void Main()
    {
        if (FindSpeed("TR-1", out double s))
            Console.WriteLine($"found: {s}");
        else
            Console.WriteLine("not found");
    }
    static bool FindSpeed(string id, out double speed )
    {
        speed = 0;
        if (id == "TR-1") { speed = 420.5; return true; }
        return false;
    }
  


}