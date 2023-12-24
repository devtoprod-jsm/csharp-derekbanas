namespace Basics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Longest int : {int.MaxValue}");
        Console.WriteLine($"Smallest int : {int.MinValue}");
        Console.WriteLine($"Longest long : {long.MaxValue}");
        Console.WriteLine($"Smallest long : {long.MinValue}");
        Console.WriteLine($"Longest decimal : {decimal.MaxValue}");
        Console.WriteLine($"Smallest decimal : {decimal.MinValue}");
        Console.WriteLine($"Longest double : {double.MaxValue}");
        Console.WriteLine($"Smallest double : {double.MinValue}");
        Console.WriteLine($"Longest float : {float.MaxValue}");
        Console.WriteLine($"Smallest float : {float.MinValue}");
        decimal decPi = 3.1413124324324325432M;
        decimal decHigh = 31232432423523563634634.1242938947932743473242912343423423M;
        Console.WriteLine($"{decPi + decHigh}");

        //TypeCasting
        bool boolFromStr = bool.Parse("false");
        int intFromStr = int.Parse("2018");
        double doubleFromStr = double.Parse("123.45");
        string stringFromBool = doubleFromStr.ToString();
        Console.WriteLine($"Datatype: {stringFromBool.GetType()}");
        Console.WriteLine($"Double to int: {(int)doubleFromStr}");
        Console.ReadLine();
    }
}

