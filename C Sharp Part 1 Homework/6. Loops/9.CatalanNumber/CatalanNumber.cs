using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumber
{
    class CatalanNumber
    {
        static void Main(string[] args)
        {
            /*  In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
                Cn = (2*n)!/(n+1)!*n!  for n>=0
             * Write a program to calculate the Nth Catalan number by given N.      */
            int N = int.Parse(Console.ReadLine());
            if (N < 0 || N > 10000)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            if (N == 0 || N == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                BigInteger numerator = 1;
                for (int i = 2 * N; i > N + 1; i--)
                {
                    numerator *= i;
                }

                BigInteger denominator = 1;
                for (int k = N; k > 1; k--)
                {
                    denominator *= k;
                }
                BigInteger result = numerator / denominator;
                Console.WriteLine(result);
            }

        }
    }
}
