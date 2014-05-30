using System;
using System.Numerics;
    class CalculateN_devidedK_
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!/K! for given N and K (1<K<N).
            int biggerNumberN;
            int lowerNumberK;
            do
	        {   
	            Console.WriteLine("Enter bigger number N:");
                biggerNumberN = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter lower number K:");
                lowerNumberK = int.Parse(Console.ReadLine());
	        } while (lowerNumberK<=0||lowerNumberK>=biggerNumberN);
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            for (int i = 1; i <= biggerNumberN; i++)
            {
                factorialN = factorialN * i;
            }
            for (int i = 1; i <= lowerNumberK; i++)
            {
                factorialK = factorialK * i;
            }
            BigInteger devisionNK = (factorialN) / (factorialK);
            Console.WriteLine("The devision of {0} and {1} is: {2}",factorialN,factorialK,devisionNK);
        }
    }

