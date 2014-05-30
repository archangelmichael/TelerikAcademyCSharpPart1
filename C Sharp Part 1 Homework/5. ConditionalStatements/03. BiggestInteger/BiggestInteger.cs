using System;

class BiggestInteger
{
    static void Main(string[] args)
    {
        //Write a program that finds the biggest of three integers using nested if statements.

        Console.WriteLine("Enter first number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggestNumber = firstNumber;
        if (secondNumber >= firstNumber)
        {
            biggestNumber = secondNumber;
            if (thirdNumber>=secondNumber)
            {
                biggestNumber = thirdNumber;
            }
            Console.WriteLine("Biggest number is: {0}" , biggestNumber);
        }
        else if (thirdNumber>=firstNumber)
        {
            biggestNumber = thirdNumber;
            Console.WriteLine("Biggest number is: {0}" , biggestNumber);
        }
        else
        {
            Console.WriteLine("Biggest number is: {0}", biggestNumber);
        }

    }
}

