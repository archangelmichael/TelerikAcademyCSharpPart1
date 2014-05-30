using System;

class CalculateSumOfNumbers
{
    static void Main(string[] args)
    {
        /*  Write a program that gets a number n and after that 
            gets more n numbers and calculates and prints their sum. */
        Console.WriteLine("Enter how many numbers you want to sum:");
        uint count = uint.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine("Enter number {0} you want to sum:", i);
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of your {0} numbers is : {1}!",count, sum);
    }
}
