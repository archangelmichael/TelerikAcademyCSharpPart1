using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleDigitRotation
{
    class TripleDigitRotation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                int digit = n % 10;
                n = n / 10;
                string result = digit.ToString() + n.ToString();
                n = int.Parse(result);
            }
            Console.WriteLine(n);
        }
    }
}
