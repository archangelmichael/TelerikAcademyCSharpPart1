using System;

class NotDivisibleBy3and7
{
    static void Main(string[] args)
    {
        //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i <= number; i++)
        {
            if (i%21!=0) //a number that is not divisible by 3 and 7 at the same time is not divisible by 21
            {
                Console.WriteLine(i);
            }
        }
    }
}

