using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeroes
{
    class OnesAndZeroes
    {
        static void Main(string[] args)
        {
            // INITIALIZATION
            long number = long.Parse(Console.ReadLine());
            long[] digits = new long[16];
            string numberToString = Convert.ToString(number, 2).PadLeft(16, '0');
            Console.WriteLine(numberToString);
            for (int i = 0; i < 16; i++)
            {
                digits[i] = long.Parse(numberToString[i].ToString());
            }
            long[,] matrix = new long[5, 63];
            // SOLUTION
            int count = 0;
            for (int row = 0; row < 5; row++)
			{
			    for (int j = 0; j < 63; j+=4)
			    {
			        if (digits[count] == 0)
                    {
                        if (row == 0)
                        {
                            matrix[row, j] = 1;
                            matrix[row, j + 1] = 1;
                            matrix[row, j + 2] = 1;
                        }
                        else if (row == 1)
                        {
                            matrix[row, j] = 1;
                            matrix[row, j+1] = 0;
                            matrix[row, j+2] = 1;
                        }
                        else if (row ==2 || row == 3)
                        {
                            matrix[row, j] = 1;
                            matrix[row, j+1] = 0;
                            matrix[row, j+2] = 1;
                        }
                        else
                        {
                            matrix[row, j] = 1;
                            matrix[row, j+1] = 1;
                            matrix[row, j+2] = 1;    
                        }
                    }
                    else
                    {
                        if (row == 0)
                        {
                            matrix[row, j] = 0;
                            matrix[row, j + 1] = 1;
                            matrix[row, j + 2] = 0;
                        }
                        else if (row == 1)
                        {
                            matrix[row, j] = 1;
                            matrix[row, j + 1] = 1;
                            matrix[row, j + 2] = 0;
                        }
                        else if (row == 2 || row == 3)
                        {
                            matrix[row, j] = 0;
                            matrix[row, j + 1] = 1;
                            matrix[row, j + 2] = 0;
                        }
                        else
                        {
                            matrix[row, j] = 1;
                            matrix[row, j + 1] = 1;
                            matrix[row, j + 2] = 1;
                        }
                    }
                    if (count == 15)
                    {
                        break;
                    }
                    count++;
			    }
                count = 0;
			}
            //PRINT MATRIX
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 63; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
