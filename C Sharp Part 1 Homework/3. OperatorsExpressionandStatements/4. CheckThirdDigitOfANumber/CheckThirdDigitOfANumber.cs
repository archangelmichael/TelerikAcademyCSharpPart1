using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckThirdDigitOfANumber
{
    static void Main(string[] args)
    {
        //Write an expression that checks for given integer if its third digit (right-to-left) is 7.
        Console.WriteLine("Please enter the number you want to check:");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 100) % 10;
        if (thirdDigit == 7)
        {
            Console.WriteLine("The Third digit of your number is 7!");
        }
        else
        {
            Console.WriteLine("The third digit of your number is different than 7!");
        }
   }
}

