using System;
using System.ComponentModel;
namespace SignalIntercept;

enum Classification { Friendly, Hostile, Unidentified }
class SignalInterceptLog
{
    static void Main()
    {
        List<string> Id = new List<string>();
        List<string> Classification = new List<string>();
        List<double> SignalStrength = new List<double>();

        int menu = 0;
        while (menu == 0)
        {
            Console.WriteLine("====Signal Intercept Log====");
            Console.WriteLine("To create a signal enter 1: ");
            Console.WriteLine("To calibration a signal strength enter 2:");
            Console.WriteLine("To see all of the signals enter 3:");
            Console.WriteLine("for Exit enter 4: ");
            string Choice = Console.ReadLine();
            if (Choice == "1")
            {
                AddSignal(Id, Classification,SignalStrength);
            }
            else if (Choice == "2")
            {
                calibration(Id, SignalStrength);

            }
            else if (Choice == "3")
            {
                GetAll(Id, Classification, SignalStrength);
            }
            else if (Choice == "4")
            {
                menu = 1;
            }
            



        }


    }
    
    static void AddSignal(List<string> id, List<string> classification, List<double> signalstrength)
    {
        Console.WriteLine("please enter ID: ");
        id.Add(Console.ReadLine());
        int n = 0;
        while (n== 0)
        {
            Classification newStatus;
            Console.WriteLine("please enter a classification: ");
            string status = Console.ReadLine();
            if (Classification.TryParse(status, out newStatus))
            {
                if (GetClassification(newStatus) != "Unknown status")
                {
                    classification.Add(GetClassification(newStatus));
                    n = 1;
                }

                    

            }
        }

        int s = 0;
        while ( s == 0)
        {
            Console.WriteLine("please enter a signalstrength: ");
            string strStrength = Console.ReadLine();
            if (double.TryParse(strStrength, out double strength))
            {
                signalstrength.Add(strength);
                s = 1;
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }

        
    }
    static int FindById(List<string> id)
    {
        Console.WriteLine("please enter ID: ");
        string currentId = Console.ReadLine();
        for (int i = 0; i<id.Count; i++)
        {
            if (id[i] == currentId)
            {
                return i;
            }
        }
        Console.WriteLine("ID not found");
        return -1;
    }
    static void calibration(List<string> id, List<double> signalstrength)
    {
        int currentId = 0;
        int n = 1;
        while (n>0)
        {
            currentId = FindById(id);
            if (currentId >= 0)
            {
                n = 0;
            }

        }
        Console.WriteLine("please enter a signalstrength: ");
        string strStrength = Console.ReadLine();
        if (double.TryParse(strStrength, out double strength))
        {
            signalstrength[currentId] = strength;
        }
        else
        {
            Console.WriteLine("invalid input");
        }

    }
    static string GetClassification(Classification status)
    {
        
        switch(status)
        {
            case Classification.Friendly:
                return "Friendly";
            case Classification.Hostile:
                return "Hostile";
            case Classification.Unidentified:
                return "Unidentified";
            default:
                return "Unknown status";
        }
    }
    static void GetAll(List<string> id, List<string> classification, List<double> signalstrength)
    {
        for (int i = 0; i < id.Count; i++)
        {
            Console.WriteLine($"[id:{id[i]}, classification:{classification[i]}, signalstrength:{signalstrength[i]}]");
        }
    }
}