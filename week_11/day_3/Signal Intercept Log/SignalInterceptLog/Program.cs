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

            }
            else if (Choice == "3")
            {

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

        Console.WriteLine("please enter a classification: ");
        Classification status = Console.ReadLine();
        classification.Add(GetClassification(status));

        Console.WriteLine("please enter a signalstrength: ");
        string strStrength = Console.ReadLine();
        if (double.TryParse(strStrength,out double strength))
        {
            signalstrength.Add(strength);
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
    static void SignalStrength(double? signal)
    {

    }
}