using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CalculateFibonacci
{
    static void Main(string[] args)
    {
        /*  Write a program that reads a number N and calculates 
         *  the sum of the first N members of the sequence of Fibonacci: 
         *  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            Each member of the Fibonacci sequence (except the first two)
         *  is a sum of the previous two members. */
        int number = 0;
        do
        {
            Console.WriteLine("Enter number N:");
            number = int.Parse(Console.ReadLine());
        } while (number <= 0 );

        BigInteger sumN = 1;
        if (number >=2 )
        {
            BigInteger firstNumber = 0;
            BigInteger currentNumber = 1;
            for (int i = 0; i < (number - 2); i++)
            {
                BigInteger tempNumber = firstNumber;
                firstNumber = currentNumber;
                currentNumber = tempNumber + currentNumber;
                sumN += currentNumber;
            }
        }
        
        Console.WriteLine(sumN);
    }
}

