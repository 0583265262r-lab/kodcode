using System;
namespace Demo;
class Day3
{
    static void Main()
    {
        int x = 10;
        TryDouble(x);
        Console.WriteLine(x);
        List<int> list = new List<int>();
        Console.WriteLine(list.Count);
        AddOne(list);
        Console.WriteLine(list.Count);
    }
    static void TryDouble(int n) { n = n * 2; }
    static void AddOne(List<int> xs) {xs.Add(1);}
    
}