using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieceOfCake
{
    class PieceOfCake
    {
        static void Main()
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());
            long third = long.Parse(Console.ReadLine());
            long fourth = long.Parse(Console.ReadLine());
            long denominator = second * fourth;
            first = first * fourth;
            third = third * second;

            long nominator = first + third;
            
            //Console.WriteLine(nominator);
            //Console.WriteLine(denominator);
            if (nominator% denominator == 0)
            {
                Console.WriteLine(nominator / denominator);
            }
            else if (nominator / denominator > 0)
            {
                Console.WriteLine(nominator/denominator);
                Console.WriteLine("{0}/{1}", nominator, denominator);
            }
            else
            {
                decimal result = (decimal)nominator / denominator;
                Console.WriteLine("{0:F22}", result);
                Console.WriteLine("{0}/{1}", nominator, denominator);
            }
        }
    }
}
