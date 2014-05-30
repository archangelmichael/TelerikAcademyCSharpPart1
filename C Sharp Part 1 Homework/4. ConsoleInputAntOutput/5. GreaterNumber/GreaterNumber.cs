using System;

class GreaterNumber
{
    static void Main(string[] args)
    {
        /*Write a program that gets two numbers from the console and prints the greater of them. 
        Don’t use if statements.*/

        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        int greaterNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("Greater number is: {0}", greaterNumber);
    }
}
