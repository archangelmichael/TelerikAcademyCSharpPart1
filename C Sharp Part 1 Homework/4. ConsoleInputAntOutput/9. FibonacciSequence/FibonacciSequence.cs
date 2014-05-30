using System;
using System.Numerics;
class FibonacciSequence
{
    static void Main(string[] args)
    {
        /*  Write a program to print the first 100 members of the sequence of
         Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */
        BigInteger firstNumber = 0;
        BigInteger currentNumber = 1;
        Console.WriteLine(firstNumber);
        Console.WriteLine(currentNumber);
        for (int i = 0; i < 100; i++)
        {
            BigInteger tempNumber = firstNumber;
            firstNumber = currentNumber;
            currentNumber = tempNumber + currentNumber;
            Console.WriteLine(currentNumber);
        }
    }
}
