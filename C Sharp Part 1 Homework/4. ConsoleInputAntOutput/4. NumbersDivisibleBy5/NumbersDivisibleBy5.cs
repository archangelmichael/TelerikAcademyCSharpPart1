using System;

class NumbersDivisibleBy5
{
    static void Main(string[] args)
    {
        /*Write a program that reads two positive integer numbers and 
        prints how many numbers p exist between them such 
        that the reminder of the division by 5 is 0 (inclusive). 
        Example: p(17,25) = 2.*/
        Console.WriteLine("Enter first number:");
        uint firstNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        uint secondNumber = uint.Parse(Console.ReadLine());
        uint biggerNumber = firstNumber;
        uint lowerNumber = secondNumber;
        if (firstNumber < secondNumber)
        {
            biggerNumber = secondNumber;
            lowerNumber = firstNumber;
        }
        uint count = 0;
        for (uint i = lowerNumber; i <= biggerNumber; i++)
        {
            if (i%5==0)
            {
                count++;
            }
        }
        Console.WriteLine("You have {0} numbers that can be divided by 5 between {1} and {2}!",count, lowerNumber,biggerNumber);
    }
}