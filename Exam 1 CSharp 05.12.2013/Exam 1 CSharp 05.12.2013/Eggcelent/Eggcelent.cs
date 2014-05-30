using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggcelent
{
    class Eggcelent
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size * 2;
            int cols = size * 3 + 1;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = 0;
                }
            }
            // TOP ROW AND BOTTOM  ROW
            for (int i = 0; i < cols; i++)
            {
                if (i >= size +1 && i < cols - size -1)
                {
                    matrix[0, i] = 1;
                    matrix[rows -1, i] = 1;
                }
            }


            int start = size -1;

            for (int row = 1; row < rows/2; row++)
            {
                for (int col = 1; col < cols / 2+1; col++)
                {
                    if (row == size-1)
                    {
                        if (col == 1)
                        {
                            matrix[row, col] = 1;
                            matrix[row + 1, col] = 1;
                            matrix[row, cols - col - 1] = 1;
                            matrix[row + 1, cols - col - 1] = 1;
                        }
                        else if (col == 2)
                        {
                            matrix[row, col] = 2;
                            matrix[row + 1, col + 1] = 2;
                            matrix[row, cols - col - 1] = 2;
                            
                        }
                        else if (col % 2 == 0 && col > 2)
                        {
                            matrix[row, col] = 2;
                            matrix[row + 1, col + 1] = 2;
                            matrix[row, cols - 1 - col] = 2;
                            matrix[row + 1, cols - col] = 2;
                        }
                    }
                    else if (start == col && start != 1)
                    {
                        matrix[row, col] = 1;
                        matrix[rows - row -1, cols - 1 - col] = 1;
                        matrix[rows - row -1, col] = 1;
                        matrix[row, cols - col - 1] = 1;
                        start -= 2;
                        break;
                    }
                    else if (start == 1)
                    {
                        if (row != size - 1 && row != size)
                        {
                            matrix[row, 1] = 1;
                            matrix[row, cols - 2] = 1;
                            matrix[rows - row -1 , 1] = 1;
                            matrix[rows - row -1, cols - 2] = 1;
                        }
                    }
                    
                    
                }
                
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write('*');
                    }
                    else if (matrix[row, col] == 2)
                    {
                        Console.Write('@');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
