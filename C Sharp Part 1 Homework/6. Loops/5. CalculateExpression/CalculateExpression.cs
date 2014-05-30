using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class CalculateExpression
{
    static void Main(string[] args)
    {
        /* Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K). */
        int biggerNumberK;
        int lowerNumberN;
        do
        {
            Console.WriteLine("Enter bigger number K:");
            biggerNumberK = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter lower number N:");
            lowerNumberN = int.Parse(Console.ReadLine());
        } while (lowerNumberN <= 0 || lowerNumberN >= biggerNumberK);
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialKN = 1;
        for (int i = 1; i <= biggerNumberK; i++)
        {
            factorialN = factorialN * i;
        }
        for (int i = 1; i <= lowerNumberN; i++)
        {
            factorialK = factorialK * i;
        }
        for (int i = 1; i <= (biggerNumberK - lowerNumberN); i++)
        {
            factorialKN = factorialKN * i;
        }
        BigInteger devisionNK = (factorialN*factorialK) / (factorialKN);
        Console.WriteLine("The devision of {0}!*{1}! and ({1}-{0})! is: {2}", lowerNumberN, biggerNumberK, devisionNK);
    }
}

