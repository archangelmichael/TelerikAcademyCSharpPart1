using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralNumbers
{
    class SpiralNumbers
    {
        static void Main(string[] args)
        {
            /*  * Write a program that reads a positive integer number N (N < 20) 
             * from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral. */
            Console.WriteLine("Enter number N: ");
            int size = int.Parse(Console.ReadLine());
            if (size <= 0 || size >= 20)
            {
                Console.WriteLine("Invalid Input!");
                return;
            }

            int[,] spiralMatrix = new int[size, size];
            int start = 0;
            int end = size;
            int count = 1;

            while (end - start >= 1)
            {
                for (int p = start; p < end; p++)
                {
                    spiralMatrix[start, p] = count;
                    count++;
                }
                for (int q = start + 1; q < end; q++)
                {
                    spiralMatrix[q, end - 1] = count;
                    count++;
                }
                for (int r = end - 2; r >= start; r--)
                {
                    spiralMatrix[end - 1, r] = count;
                    count++;
                }
                for (int s = end - 2; s >= start + 1; s--)
                {
                    spiralMatrix[s, start] = count;
                    count++;
                }
                start = start + 1;
                end = end - 1;
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == size - 1)
                    {
                        Console.Write(spiralMatrix[i, j]);
                    }
                    else
                    {
                        Console.Write(spiralMatrix[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
