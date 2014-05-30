using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FourthBitCheck
{
    static void Main(string[] args)
    {
        //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
        Console.WriteLine("Please enter your number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the position you want to check:");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int check = number & mask;
        int bit = check >> position;
        Console.WriteLine("The bit at position {0} is : {1} ",position,bit);   // 1
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

