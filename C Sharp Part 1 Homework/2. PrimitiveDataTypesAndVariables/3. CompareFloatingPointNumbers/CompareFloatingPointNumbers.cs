using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter First Number:");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number:");
        decimal b = decimal.Parse(Console.ReadLine());

        decimal difference = Math.Abs(a - b);
        bool answer = (difference <= (decimal)0.000001);       
        Console.WriteLine(answer);
    }   
}

