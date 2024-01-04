namespace ConditionsAndWhile;
class Program
{
    static void Main(string[] args)
    {
        int age = 37;
        if (age <= 5 || age >= 67)
        {
            Console.WriteLine("Sorry you are not for school");
        }
        else if (age > 5 && age <= 12)
        {
            Console.WriteLine("Time for elementary school");
        }
        else if (age > 12 && age <= 15)
        {
            Console.WriteLine("Time for middle school");
        }
        else if (age > 15 && age <= 17)
        {
            Console.WriteLine("Time for high school");
        }
        else
        {
            Console.WriteLine("Time for college");
        }

        bool canDrive = age >= 17 ? true : false;
        Console.WriteLine($"canDrive:  {canDrive}");


        //Switch
        switch (age)
        {
            case 1:
            case 2:
                Console.WriteLine("Go to day care");
                break;
            case 3:
            case 4:
                Console.WriteLine("Go to preschool");
                break;
            case 5:
                Console.WriteLine("Go to kindergarten");
                break;
            default:
                goto OtherSchool;
        }
    OtherSchool:
        Console.WriteLine("Go to elementary,middle,high or college");

        //while
        int i = 1;
        while (i < 10)
        {
            if (i % 2 == 0)
            {
                i++;
                continue;
            }
            if (i == 9)
                break;
            Console.WriteLine(i);
            i++;
        }
        Console.ReadLine();

    }
}
