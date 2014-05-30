using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaBabaMiSmetalnika
{
    class NaBabaMiSmetalnika
    {
        static void Main()
        {
            // input
            int width = int.Parse(Console.ReadLine());
            int[,] smetalo = new int[width, width];
            for (int row = 0; row < 8; row++)
            {
                long number = long.Parse(Console.ReadLine());
                string numberToString = Convert.ToString(number, 2).PadLeft(width, '0');
                for (int col = 0; col < width; col++)
                {
                    smetalo[row, col] = int.Parse(numberToString[col].ToString());
                }
            }

            //print smetalo
            //for (int row = 0; row < 8; row++)
            //{
            //    for (int col = 0; col < width; col++)
            //    {
            //        Console.Write(smetalo[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            int count = 0;

            // solution
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                else if (command == "reset")
	            {
                    for (int row = 0; row < 8; row++)
			        {
			            count = 0;
                        for (int i = 0; i < width; i++)
                        {
                            if (smetalo[row,i] == 1)
                            {
                                smetalo[row, i] = 0;
                                count++;
                            }
                        }
                        for (int i = 0; i < width && count != 0; i++)
                        {
                            smetalo[row, i] = 1;
                            count--;
                        }
			        }
                    continue;
	            }
                int line = int.Parse(Console.ReadLine());
                int position = int.Parse(Console.ReadLine());
                if (position <0)
                {
                    position *= -1;
                }
                if (command == "right" && line >=0 && line <=8)
                {
                    count = 0;
                    for (int i = width-1; i >= position; i--)
                    {
                        if (smetalo[line,i] == 1)
                        {
                            smetalo[line, i] = 0;
                            count++;
                        }
                    }
                    for (int i = width-1; i >= position && count != 0; i--)
                    {
                        smetalo[line, i] = 1;
                        count--;
                    }
                }
                else if (command == "left" && line >= 0 && line <= 8)
                {
                    count = 0;
                    for (int i = 0; i <= position ; i++)
                    {
                        if (smetalo[line, i] == 1)
                        {
                            smetalo[line, i] = 0;
                            count++;
                        }
                    }
                    for (int i = 0; i <= position && count != 0; i++)
                    {
                        smetalo[line, i] = 1;
                        count--;
                    }
                }
                
            }
            // output
            long blankCount = 0;
            bool blank = true;
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (smetalo[i,j] == 1)
                    {
                        blank = false;
                        break;
                    }
                    else
                    {
                        blank = true;
                    }
                }
                if (blank)
                {
                    blankCount++;
                }
                blank = false;
            }
            //Console.WriteLine(blankCount);

            
            long result = 0;
            long final = 0; //StringBuilder final = new StringBuilder(64);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (smetalo [i,j] == 1)
	                {
		                final += (long)Math.Pow(2,width-1-j);
	                }
                }
                //Console.WriteLine(final);
                result += final;
                //Console.WriteLine(result);
                
                final = 0;
            }
            //Console.WriteLine(blankCount);
            Console.WriteLine(result * blankCount);
        }
    }
}
