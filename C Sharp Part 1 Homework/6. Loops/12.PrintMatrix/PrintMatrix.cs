using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrix
{
    class PrintMatrix
    {
        static void Main(string[] args)
        {
            /*  Write a program that reads from the console a positive integer number N (N < 20) 
             * and outputs a matrix like the following:	N = (3,3)			N = (4,4) */
            Console.WriteLine("Enter number N: ");
            int numberN = int.Parse(Console.ReadLine());
            if (numberN <=0 || numberN >= 20 )
            {
                Console.WriteLine("Invalid Input!");
                return;
            }
            for (int row = 1; row <= numberN; row++)
            {
                for (int col = row; col < numberN+row; col++)
                {
                    Console.Write(col + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
}
