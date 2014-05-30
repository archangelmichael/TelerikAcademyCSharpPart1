using System;

class IsNumberPrime
{
    static void Main(string[] args)
    {
        /*Write an expression that checks if given positive integer number 
         * n (n ≤ 100) is prime. E.g. 37 is prime.*/
        Console.WriteLine("Enter your number:");
        uint number = 0u;
        uint count = 0u;
        do
        {
            number = uint.Parse(Console.ReadLine());
        } while (number>100);
        for (int i = 2; i <=Math.Sqrt(number); i++)    //if it is divisible by any number that number is from 0 to sqrt of our number.
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("your number is prime!");
        }
        else
        {
            Console.WriteLine("your number is not prime!");
        }
    }
}

