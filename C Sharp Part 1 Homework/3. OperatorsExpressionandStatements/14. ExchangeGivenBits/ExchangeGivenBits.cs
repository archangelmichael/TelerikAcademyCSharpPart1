using System;

class ExchangeGivenBits
{
    static void Main(string[] args)
    {
        /* Write a program that exchanges bits {p, p+1, …, p+k-1) 
         * with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer. */
        Console.WriteLine("Enter your number n:");
        uint number = uint.Parse(Console.ReadLine());
        byte p, q, k;
        do
        {
            Console.WriteLine("Enter your lower number p to start from:");
            p = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your bigger number q to start from:");
            q = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many bits k you want to exchange:");
            k = byte.Parse(Console.ReadLine());
        } while (q<=p+k); //check not to overstep exchanging bits
        
        uint mask = 1;
        uint bit1;
        uint bit2;
        uint number1;
        
        Console.WriteLine("{0} : Original number : {1}", Convert.ToString(number, 2).PadLeft(32, '0'), number);
        for (byte i = 0; i < k; i++, p++, q++)
        {
            mask = mask << p;
            bit1 = (mask & number) >> p;
            mask = mask >> p;
            mask = mask << q;
            bit2 = (mask & number) >> q;
            mask >>= q;
            if (bit1 != bit2)
            {
                switch (bit1)
                {
                    case 1:
                        number1 = number | (mask << q);
                        number = number1 ^ (mask << p);
                        break;
                    case 0:
                        number1 = number ^ (mask << q);
                        number = number1 | (mask << p);
                        break;
                }

            }
        }
        Console.WriteLine("{0} : Converted number : {1} ", Convert.ToString(number, 2).PadLeft(32, '0'), number);
    }
}

