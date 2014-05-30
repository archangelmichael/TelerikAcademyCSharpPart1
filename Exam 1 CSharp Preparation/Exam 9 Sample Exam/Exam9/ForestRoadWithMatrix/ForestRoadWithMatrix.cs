using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoadWithMatrix
{
    class ForestRoadWithMatrix
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());
            int[,] matrix = new int [number*2 - 1, number];

            // solution
            int currentRow = 0;
            int currentCol = 0;
            bool stop = false;

            while (true)
	        {
	            matrix[currentRow , currentCol] = 1;
                
                if (currentCol < number-1 && !stop)
	            {
                    currentRow++ ;
                    currentCol++;
                }
                else if(currentCol == number-1 && !stop)
	            {
                     stop = true;
                     currentCol--;
                     currentRow++;
	            }
                else if (currentCol <number-1 && currentCol >0 && stop )
                {
                    currentCol--;
                    currentRow++;
                }
                else
                {
                    break;
                }
	        }

            //output
            for (int row = 0; row < (2*number -1); row++)
			{
			    for (int col = 0; col < number; col++)
			    {
                    
                    if (matrix[row,col] == 0)
                    {
                        Console.Write('.');                        
                    }
                    if (matrix[row,col] == 1)
                    {
                        Console.Write('*');
                    }

			        //Console.Write(matrix[row,col]);
			    }
                Console.WriteLine();
			}
        }
    }
}
