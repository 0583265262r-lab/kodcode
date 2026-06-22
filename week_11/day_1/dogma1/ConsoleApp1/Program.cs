using System;

namespace Demo;1

    class Name
    {
        static void Main()
        {
            Console.Write("Enter speed: ");
            string raw = Console.ReadLine();
            double speed = double.Parse(raw); // convert the text to a number
            Console.WriteLine($"Speed doubled is {speed * 2}");
        }
    }
