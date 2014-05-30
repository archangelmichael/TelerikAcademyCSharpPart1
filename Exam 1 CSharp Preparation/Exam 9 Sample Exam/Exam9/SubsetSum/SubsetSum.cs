using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
    class SubsetSum
    {
        static void Main()
        {
            long sum = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long[] numbers = new long [n];
            // initialization
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            int result = 0;
            long subsetSum = 0;
            bool hit = false;
            //solution

            
            for (int firstNumber = 0; firstNumber < n; firstNumber++)
            {
                subsetSum = numbers[firstNumber];
                result = 1;
                if (subsetSum == sum)
                {
                    hit = true;
                    Console.WriteLine(result);
                    break;
                }
                for (int lastNumber = n-1; lastNumber > firstNumber; lastNumber--)
                {
                    result++;
                    subsetSum += numbers[lastNumber];
                    if (subsetSum == sum)
                    {
                        hit = true;
                        Console.WriteLine(result);
                        return;
                    }
                }
            }
            if (hit == false)
            {
                Console.WriteLine("0");
            }
        }
    }
}
