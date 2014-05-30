using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAllLoveBits2
{
    class WeAllLoveBits2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] endResult = new int [n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                string normalNumberAsString = Convert.ToString(number, 2);
                string reverseNumberAsString = "";
                for (int j = normalNumberAsString.Length -1; j >= 0; j--)
                {
                    reverseNumberAsString += normalNumberAsString[j];
                }
                endResult[i] = Convert.ToInt32(reverseNumberAsString,2);
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(endResult[i]);
            }
            
        }
    }
}
