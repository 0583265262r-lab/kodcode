using System;

namespace Management;
class FleetManagement
{
    

    static void Main()
    {

        List<string> Id = new List<string>();
        List<int> Speeds = new List<int>();
        List<double> Heading = new List<double>();
        int mainLoop = 0;
        while (mainLoop == 0)
        {
            Console.WriteLine("enter 1 to exit " +
                              "\n2 to find track by ID " +
                              "\n3 to add new track " +
                              "\nany number to continue: ");
            
            
            string chose = Console.ReadLine();
            if (chose == "1")
            {
                mainLoop = 1;
            }
            else if(chose == "2")
            {
                FindId(Id, Speeds, Heading);
                continue;
            }
            else if (chose == "3")
            {
                AddTrack(Id, Speeds, Heading);
            }
            else
            {
                mainLoop = 0;
            }
        }
        
    }
    
    
    static void AddTrack(List<string> id, List<int> speed, List<double> heading)
    {
        string speedStr = "";
        string headingStr = "";
        Console.WriteLine("enter ID: ");
        id.Add(Console.ReadLine());

        int checker = 0;
        while (checker == 0)
        {
            Console.WriteLine("enter Speeds: ");
            speedStr = Console.ReadLine();
            if (int.TryParse(speedStr, out int speeds))
            {
                speed.Add(speeds);
                checker = 1;
            }
            else
            {
                Console.WriteLine("Error: please enter a number");
            }
        }
        int checker1 = 0;
        while (checker1 == 0)
        {
            Console.WriteLine("enter a heading: ");
            headingStr = Console.ReadLine();
            if (double.TryParse(headingStr, out double head))
            {
                heading.Add(head);
                checker1 = 1;
            }
            else
            {
                Console.WriteLine("Error: please enter a number");
            }
        }
        for (int index = 0; index < speed.Count; index++)
        {
            Console.Write($"tack {index + 1} [id:{id[index]}, ");
            Console.Write($"speed: {speed[index]}, ");
            Console.Write($"heading: {heading[index]}]");
            Console.Write($"\n");


        }
    }

    static int FindId(List<string> id, List<int> speed, List<double> heading)
    {
        Console.WriteLine("enter ID: ");
        string IdChoice = Console.ReadLine();
        for (int index = 0; index < speed.Count; index++)
        {
            if (IdChoice == id[index])
            {
                Console.Write($"tack {index + 1} [id:{id[index]}, ");
                Console.Write($"speed: {speed[index]}, ");
                Console.Write($"heading: {heading[index]}]");
                Console.Write($"\n");
                return index;
            }
            else
            {
                Console.WriteLine("ID not found");
            }
        }
        int NotFound = -1;
        return NotFound;
    }
}

