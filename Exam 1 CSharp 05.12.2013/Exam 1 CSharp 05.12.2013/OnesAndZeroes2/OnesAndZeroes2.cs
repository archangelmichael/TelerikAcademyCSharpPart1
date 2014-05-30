using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeroes2
{
    class OnesAndZeroes2
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            long[] digits = new long[16];
            string numberToString = Convert.ToString(number, 2).PadLeft(16, '0');
            for (int i = 0; i < 16; i++)
            {
                digits[i] = long.Parse(numberToString[i].ToString());
            }
            long[,] matrix = new long[5, 64];
            
            

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 64; col++)
                {
                    matrix[row, col] = 0;
                }
            }
            // LAST ROW
            for (int col = 0; col < 64; col++)
            {
                if (col % 4 != 0)
                {
                    matrix[4, col] = 1;
                }
            }
            
            // MID
            for (int row = 2; row < 4; row++)
            {
                int counter = 0;
                for (int col = 0; col < 64; col++)
                {
                    if (col % 4 == 0 )
                    {
                        counter++;
                        continue;
                    }
                    else if (col % 4 == 1 || col% 4 == 3)
                    {
                        if (digits[counter-1] == 0)
	                    {
                            matrix[row, col] = 1;
	                    }
                    }
                    else if (col % 4 == 2)
                    {
                        if (digits[counter-1] == 1)
                        {
                            matrix[row, col] = 1;
                        }
                    }
                }
            }


            // TOP
            for (int row = 0; row < 2; row++)
            {
                int counter = 0;
                for (int col = 0; col < 64; col++)
                {
                    if (row == 0)
                    {
                        if (col % 4 == 0)
                        {
                            counter++;
                            continue;
                        }
                        else
                        {
                            if (digits[counter-1] == 0)
	                        {
                                matrix[row, col] = 1;
	                        }
                    
                            else
                            {
                                if (col % 4 == 2)
                                {
                                    matrix[row, col] = 1;
                                }
                            }
                        }

                    }
                    else
                    {
                        if (col % 4 == 0)
                        {
                            counter++;
                            continue;
                        }
                        else
                        {
                            if (digits[counter - 1] == 1)
                            {
                                if (col % 4 == 1 || col % 4 == 2)
                                {
                                    matrix[row, col] = 1;
                                }
                            }
                            else  // digit = 0
                            {
                                if (col % 4 == 1 || col % 4== 3)
                                {
                                    matrix[row, col] = 1;
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                matrix[i, 0] = 2;
            }

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 64; col++)
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


