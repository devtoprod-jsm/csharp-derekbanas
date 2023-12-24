namespace StringBasics;
class Program
{
    static void Main(string[] args)
    {
        string randString = "This is a string";
        Console.WriteLine($"Length of the string: {randString.Length}");
        Console.WriteLine($"String contains is: {randString.Contains("is")}");
        Console.WriteLine($"Index of is : {randString.IndexOf("is")}");
        Console.WriteLine($"Remove String: {randString.Remove(10,6)}");
        Console.WriteLine($"Replace string: {randString.Replace("string", "sentence")}");
        Console.WriteLine($"Compare: {String.Compare("A", "a", StringComparison.OrdinalIgnoreCase)}");
        Console.WriteLine($"Pad Left: {randString.PadLeft(20, '-')}");
        Console.WriteLine($"Pad Right: {randString.PadRight(20, '-')}");
        Console.WriteLine($"Pad Left and Right: {randString.PadRight(20, '-').PadLeft(24,'.')}");
        Console.WriteLine($"To upper: {randString.ToUpper()}");
        Console.WriteLine($"To lower: {randString.ToLower()}");
        string newString = String.Format("{0} saw a {1} eating {2} in the {3}", "Peter", "rabbit", "carrot", "field");
        Console.Write(newString + "\n");
        Console.WriteLine(@"Exactly what I typed \n");
        Console.ReadLine();
    }
}

