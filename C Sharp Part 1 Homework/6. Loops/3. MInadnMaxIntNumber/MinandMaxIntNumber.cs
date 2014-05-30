using System;

class MinandMaxIntNumber
{
    static void Main(string[] args)
    {
        //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
        Console.WriteLine("Enter how many numbers you want to compare:");
        int numberCount = int.Parse(Console.ReadLine());
        int numberMin = 0;
        int numberMax = 0;
        for (int i = 0; i < numberCount; i++)
        {
            Console.WriteLine("Enter next number:");
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber>=numberMax)
            {
                numberMax = currentNumber;
            }
            if (currentNumber<=numberMin)
            {
                numberMin = currentNumber;
            }
        }
        Console.WriteLine("The maximum number is: {0}",numberMax);
        Console.WriteLine("The minimum number is: {0}",numberMin);
    }
}

