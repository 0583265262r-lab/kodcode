using System;
namespace Demo
{
    class Name
    {
        static void Main()
        {

            int id = 17; // whole number — int
            double speed = 412.5; // number with a fraction — double
            double heading = 270.0; // degrees, 0-359
            string status = "active"; // text — string
            bool isLocked = true; // true/false — bool
            Console.WriteLine($"Track {id}: {speed} kn, heading {heading}, status{ status}");
            Console.WriteLine($"Radar locked: {isLocked}");
            Console.Write("Enter speed: ");
            string raw = Console.ReadLine();
        }
}


}


