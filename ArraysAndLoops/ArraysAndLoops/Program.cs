namespace ArraysAndLoops;
class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = new string[3];
        stringArray[0] = "Jaisrith";
        Console.WriteLine(stringArray[0]);
        string[] inline = new string[] { "Jaisrith", "Sindhu", "Mohan" };
        Console.WriteLine(inline[1]);
        var employees = new[] { "Jaisrith", "Sindhu" };
        Console.WriteLine(employees[0]);
        object[] randomArray = { "Jaisrith", 1, true };
        Console.WriteLine(randomArray[0].GetType());
        Console.WriteLine(randomArray.Length);
        PrintArray(randomArray, "ForEach");
        Array.Reverse(randomArray);
        for (int i =0; i < randomArray.Length; i++)
        {
            Console.WriteLine("Index: {0} , Value: {1}", i, randomArray[i]);
        }

        //multidimension arrays
        string[,] multiDimension = new string[2,2] { { "Jaisrith", "Tella" }, { "Sindhusri", "Nangineni" } };
        for (int i=0; i < multiDimension.GetLength(0); i++)
        {
            for (int j = 0; j < multiDimension.GetLength(0); j++)
            {
                Console.WriteLine(multiDimension[i,j]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }

    //Functions

    public static void PrintArray(object[] objectArray, string message)
    {
        foreach (object i in objectArray)
        {
            Console.WriteLine("{0} : {1}", message, i);
        }
    }
}

