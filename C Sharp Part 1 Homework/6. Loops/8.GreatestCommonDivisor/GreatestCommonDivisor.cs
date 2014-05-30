using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            /*  Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
             *  Use the Euclidean algorithm (find it in Internet).  */
            /*  Formal description of the Euclidean algorithm
                Input Two positive integers, a and b.
                Output The greatest common divisor, g, of a and b.
                Internal computation
                If a<b, exchange a and b.
                Divide a by b and get the remainder, r. If r=0, report b as the GCD of a and b.
                Replace a by b and replace b by r. Return to the previous step. */
            int biggerA;
            int lowerB;
            do
            {
                Console.WriteLine("Enter bigger number N:");
                biggerA = Math.Abs(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter lower number K:");
                lowerB = Math.Abs(int.Parse(Console.ReadLine()));
            } while (lowerB == 0 || biggerA ==0);
            int commonDevider = 1;
            int remainder = 1;
            int number = 1;
            if ( lowerB > biggerA )
            {
                number = lowerB;
                lowerB = biggerA;
                biggerA = number;
            }
            
            do
            {
                remainder = biggerA % lowerB;
                commonDevider = lowerB;
                biggerA = lowerB;
                lowerB = remainder;
                
            } while (lowerB >= 1);
            Console.WriteLine("The GCD is: {0}", commonDevider);
        }
    }
}
