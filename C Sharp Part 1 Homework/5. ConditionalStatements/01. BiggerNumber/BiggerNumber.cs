using System;

class BiggerNumber
{
    static void Main(string[] args)
    {
        /* Write an if statement that examines two integer variables and 
        exchanges their values if the first one is greater than the second one.*/
        Console.WriteLine("Enter first number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int secondNumber = int.Parse(Console.ReadLine());
        int biggerNumber = firstNumber;
        if (secondNumber >= firstNumber)
        {
            biggerNumber = secondNumber;
            secondNumber = firstNumber;
            firstNumber = biggerNumber;
            Console.WriteLine("The bigger number is {0} and the lower is {1}",firstNumber,secondNumber);
        }
        else
        {
            Console.WriteLine("The bigger number is {0} and the lower is {1}", firstNumber, secondNumber);
        }
    }
}
