using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberInEnglish2
{
    static void Main(string[] args)
    {
        //This is second decision, Which is a lot shorter, but as exact for small and capital letters as the previous
        /* * Write a program that converts a number in the range [0...999] 
         * to a text corresponding to its English pronunciation. Examples:
	        0  "Zero"
	        273  "Two hundred seventy three"
	        400  "Four hundred"
	        501  "Five hundred and one"
	        711  "Seven hundred and eleven"   */
        string[] specials = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
                             "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                             "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] tens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }
        while (number < 0 || number > 999);

        int firstDigit = number / 100;
        int secondDigit = number / 10;
        int secondDigitHundreds = (number % 100) / 10;
        int secondDigit2 = number % 100;
        int thirdDigit = number % 10;

        if (number >= 0 && number < 20)
        {
            Console.WriteLine(specials[number]);
        }
        else if (number > 19 && number < 100)
        {
            if (number % 10 == 0)
            {
                Console.WriteLine(tens[secondDigit - 2]);
            }
            else
            {
                Console.WriteLine(tens[secondDigit - 2] + " " + specials[thirdDigit]);
            }
        }
        else if (number > 99 && number < 1000)
        {
            if (secondDigit2 == 0)
            {
                Console.WriteLine(specials[firstDigit] + " Hundred");
            }
            else if (secondDigit2 > 0 && secondDigit2 < 20)
            {
                Console.WriteLine(specials[firstDigit] + " Hundred " + "and " + specials[secondDigit2]);
            }
            else if (thirdDigit == 0)
            {
                Console.WriteLine(specials[firstDigit] + " Hundred " + tens[secondDigitHundreds - 2]);
            }
            else
            {
                Console.WriteLine(specials[firstDigit] + " Hundred " + tens[secondDigitHundreds - 2] + " " + specials[thirdDigit]);
            }
        }
    }
}

