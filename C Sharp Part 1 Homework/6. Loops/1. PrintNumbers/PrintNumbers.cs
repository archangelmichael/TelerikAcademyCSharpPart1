using System;

class PrintNumbers
{
    static void Main(string[] args)
    {
        //Write a program that prints all the numbers from 1 to N.
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
