using System;

class ShowAgeAfter10Years
{
    static void Main(string[] args)
    {
        Console.WriteLine("What old are you?");
        string myAgeNow = Console.ReadLine();
        try
        {
            int age = int.Parse(myAgeNow);
            if (age <= 0 || age > 130)
                throw new NotImplementedException();
            Console.WriteLine("You will be {0} years old in 10 years!",age+10);
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("You have entered an invalid value!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a valid number.");
        }

    }
}

