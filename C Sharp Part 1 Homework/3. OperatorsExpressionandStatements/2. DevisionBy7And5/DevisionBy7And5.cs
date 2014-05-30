using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DevisionBy7And5
{
    static void Main(string[] args)
    {
        //Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
        int number = int.Parse(Console.ReadLine());
        bool check = (number % 5 == 0 && number % 7 == 0);
        //bool check = number % 35 == 0; is also possible 
        if (check)
        {
            Console.WriteLine("Your number can be devided without remainder by 5 and 7!");
        }
        else
        {
            Console.WriteLine("Your number can't be devided without remainder by 5 and 7!");
        }
    }
}

