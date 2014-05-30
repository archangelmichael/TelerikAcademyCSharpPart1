using System;

class Read3IntegersAndSum
{
    static void Main(string[] args)
    {
        //Write a program that reads 3 integer numbers from the console and prints their sum.
        Console.WriteLine("Enter your first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your thitd number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of your numbers is:{0}",firstNumber+secondNumber+thirdNumber);
    }
}

