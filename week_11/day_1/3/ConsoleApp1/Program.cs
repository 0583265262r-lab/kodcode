using System;
using System.Diagnostics;
namespace SingleTrackConsoleReadout;

class SingleTrack
{
    
    
    static void Main()
        
    {
        int id = 0;
        int speed = 0;
        string speedCategory= "";
        double heading = 0;
        string status1 = "";
        int n = 0;
        while (n == 0)

        { Console.Write("enter a ID: ");
        string strId = Console.ReadLine();
        
            if (int.TryParse(strId, out id))
            {
                Console.WriteLine(id);
                n = 1;
            }
            else
                Console.WriteLine("Invalid ID input.");
            
        }
        int s = 0;
        while (s == 0)
            {Console.Write("enter a speed: ");
        string row = Console.ReadLine();
            if (int.TryParse(row, out int speed1))
            
            {
                speed = speed1;
                string speedCategory1;
                if (speed1 < 100) speedCategory1 = "slow";
                else if (speed1 < 200) speedCategory1 = "medium";
                else
                    speedCategory1 = "fast";
                speedCategory = speedCategory1;

                s = 1;
            }
            else
                Console.WriteLine("Invalid speed input.");
        }
        int h = 0;
        while (h == 0)
            {Console.Write("enter a heading: ");
        string head = Console.ReadLine();

            if (double.TryParse(head, out double heading1))
            {
                heading = heading1;
                if (heading1 >= 0 & heading1 <= 359)

                    h = 1;
                
                    
                else

                    Console.WriteLine("Worning: heading is out of range. It should be between 0 and 359.");
            }

            else
                Console.WriteLine("Invalid heading input.");

        }
        int p = 0;
        while (p == 0)
            {Console.Write("enter a status: ");
        string status = Console.ReadLine();
            if (status == "cruising" | status == "turning"
                | status == "stopped" | status == "accelerating")
            {
                p = 1;
                status1 = status;
                
            }
            else
            {
                Console.WriteLine("Invalid status input.");
            }
        }
        
        Console.WriteLine("=== Track Report ===");
        Console.WriteLine($"Track ID:{id}");
        Console.WriteLine($"speed:{speed} -> {speedCategory}");
        Console.WriteLine($"heading:{heading} degrees");
        Console.WriteLine($"status:{status1}");
        Console.WriteLine($"Division Demo1 {heading}/30 = {(int)heading / 30}(int), {heading}/30 = {heading / (double)30}(double)");
        Console.WriteLine($"Division Demo2 {speed}/60 = {speed / 60}(int), {heading}/30 = {(double)speed / 60}(double)");




    }
}
