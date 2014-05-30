using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryFemaleGPS
{
    class AngryFemaleGPS
    {
        static void Main()
        {
            //input
            string number = Console.ReadLine();
            long oddsum = 0;
            long evensum = 0;
            string direction = "straight";

            // solution
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '-')
                {
                    continue;
                }
                else if ((long)number[i] % 2 == 0)
                {
                    evensum += long.Parse(number[i].ToString());
                }
                else
                {
                    oddsum += long.Parse(number[i].ToString());
                }

            }
            long result = oddsum;
            if (oddsum > evensum)
            {
                
                direction = "left";
            }
            else if (oddsum < evensum)
            {
                result = evensum;
                direction = "right";
            }

            // output
            Console.WriteLine("{0} {1}",direction, result);
        }
    }
}
