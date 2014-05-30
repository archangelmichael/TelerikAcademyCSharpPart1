using System;

class PrintAllNumberInInterval
{
    static void Main(string[] args)
    {
        /*  Write a program that reads an integer number n from the console 
         and prints all the numbers in the interval [1..n], each on a single line. */
        Console.WriteLine("Enter your number:");
        uint number = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}