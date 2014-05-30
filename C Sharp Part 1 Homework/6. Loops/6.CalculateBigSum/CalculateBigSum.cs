using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class CalculateBigSum
    {
        static void Main(string[] args)
        {
            /*  Write a program that, for a given two integer numbers N and X, 
             * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN  */

            int numberN = 0;
            bool numberNOK = false;
            int numberX = 0;
            bool numberXOK = false;
            do
            {
                Console.WriteLine("Enter number N:");
                numberNOK = int.TryParse(Console.ReadLine(), out numberN);
                Console.WriteLine("Enter number X:");
                numberXOK = int.TryParse(Console.ReadLine(), out numberX);
            } while (numberNOK != true || numberNOK != true);
            double sum = 1;
            BigInteger factorial = 1;
            for (int i = 1; i <= numberN; i++)
            {
                factorial = factorial * i;

                sum = sum + (double) factorial / Math.Pow(numberX, i);
            }
            Console.WriteLine(sum);
        }
    }

