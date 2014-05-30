using System;

class NumberInEnglish
{
    static void Main(string[] args)
    {
        /* * Write a program that converts a number in the range [0...999] 
         * to a text corresponding to its English pronunciation. Examples:
	        0  "Zero"
	        273  "Two hundred seventy three"
	        400  "Four hundred"
	        501  "Five hundred and one"
	        711  "Seven hundred and eleven"   */
        Console.WriteLine("Enter number from 0 to 999:");
        int number = int.Parse(Console.ReadLine());
        int hundrets = number / 100;
        int tens = number % 100 ;
        int middleDigit = (number / 10) % 10;
        int lastDigit = number % 10;
        if (number ==0 )
        {
            Console.WriteLine("Zero");
        }
        else if (hundrets > 0)     //number has hundrets
        {
            switch (hundrets)
            {
                
                case 1: Console.Write("One hundred ");
                    break;
                case 2: Console.Write("Two hundred ");
                    break;
                case 3: Console.Write("Three hundred ");
                    break;
                case 4: Console.Write("Four hundred ");
                    break;
                case 5: Console.Write("Five hundred ");
                    break;
                case 6: Console.Write("Six hundred ");
                    break;
                case 7: Console.Write("Seven hundred ");
                    break;
                case 8: Console.Write("Eight hundred ");
                    break;
                case 9: Console.Write("Nine hundred ");
                    break;   
            }
            if (middleDigit >= 2)
            {
                switch (middleDigit)
                {
                    case 2: Console.Write("twenty ");
                        break;
                    case 3: Console.Write("thirty ");
                        break;
                    case 4: Console.Write("fourty ");
                        break;
                    case 5: Console.Write("fifty ");
                        break;
                    case 6: Console.Write("sixty ");
                        break;
                    case 7: Console.Write("seventy ");
                        break;
                    case 8: Console.Write("eighty ");
                        break;
                    case 9: Console.Write("ninety ");
                        break;
                }
                switch (lastDigit)
                {
                    case 0: Console.WriteLine("!");
                        break;
                    case 1: Console.WriteLine("one !");
                        break;
                    case 2: Console.WriteLine("two !");
                        break;
                    case 3: Console.WriteLine("three !");
                        break;
                    case 4: Console.WriteLine("four !");
                        break;
                    case 5: Console.WriteLine("five !");
                        break;
                    case 6: Console.WriteLine("six !");
                        break;
                    case 7: Console.WriteLine("seven !");
                        break;
                    case 8: Console.WriteLine("eight !");
                        break;
                    case 9: Console.WriteLine("nine !");
                        break;
                }
            }
            else if (middleDigit == 1)
            {
                switch (tens)
                {
                    case 10: Console.WriteLine("and ten !");
                        break;
                    case 11: Console.WriteLine("and eleven !");
                        break;
                    case 12: Console.WriteLine("and twelve !");
                        break;
                    case 13: Console.WriteLine("and thirteen !");
                        break;
                    case 14: Console.WriteLine("and fourteen !");
                        break;
                    case 15: Console.WriteLine("and fifteen !");
                        break;
                    case 16: Console.WriteLine("and sixteen !");
                        break;
                    case 17: Console.WriteLine("and seventeen !");
                        break;
                    case 18: Console.WriteLine("and eighteen !");
                        break;
                    case 19: Console.WriteLine("and nineteen !");
                        break;

                }
            }
            else
            {
                switch (lastDigit)
                {
                    case 0: Console.WriteLine("!");
                        break;
                    case 1: Console.WriteLine("and one!");
                        break;
                    case 2: Console.WriteLine("and two!");
                        break;
                    case 3: Console.WriteLine("and three!");
                        break;
                    case 4: Console.WriteLine("and four!");
                        break;
                    case 5: Console.WriteLine("and five!");
                        break;
                    case 6: Console.WriteLine("and six!");
                        break;
                    case 7: Console.WriteLine("and seven!");
                        break;
                    case 8: Console.WriteLine("and eight!");
                        break;
                    case 9: Console.WriteLine("and nine!");
                        break;
                }
            }
        }

        else if (middleDigit >= 2)              // number doesnt have hundrets, but has tens >=20
        {
            switch (middleDigit)
                {
                    case 2: Console.Write("Twenty ");
                        break;
                    case 3: Console.Write("Thirty ");
                        break;
                    case 4: Console.Write("Fourty ");
                        break;
                    case 5: Console.Write("Fifty ");
                        break;
                    case 6: Console.Write("Sixty ");
                        break;
                    case 7: Console.Write("Seventy ");
                        break;
                    case 8: Console.Write("Eighty ");
                        break;
                    case 9: Console.Write("Ninety ");
                        break;
                }
                switch (lastDigit)
                {
                    case 0: Console.WriteLine("!");
                        break;
                    case 1: Console.WriteLine("one !");
                        break;
                    case 2: Console.WriteLine("two !");
                        break;
                    case 3: Console.WriteLine("three !");
                        break;
                    case 4: Console.WriteLine("four !");
                        break;
                    case 5: Console.WriteLine("five !");
                        break;
                    case 6: Console.WriteLine("six !");
                        break;
                    case 7: Console.WriteLine("seven !");
                        break;
                    case 8: Console.WriteLine("eight !");
                        break;
                    case 9: Console.WriteLine("nine !");
                        break;
                }
        }
        else if (middleDigit == 1)      // number doesnt have hundrets, but has tens <20 and >=10
	    {

            switch (tens)
                {
                    case 10: Console.WriteLine(" Ten !");
                        break;
                    case 11: Console.WriteLine(" Eleven !");
                        break;
                    case 12: Console.WriteLine(" Twelve !");
                        break;
                    case 13: Console.WriteLine(" Thirteen !");
                        break;
                    case 14: Console.WriteLine("Fourteen !");
                        break;
                    case 15: Console.WriteLine(" Fifteen !");
                        break;
                    case 16: Console.WriteLine(" Sixteen !");
                        break;
                    case 17: Console.WriteLine(" Seventeen !");
                        break;
                    case 18: Console.WriteLine(" Eighteen !");
                        break;
                    case 19: Console.WriteLine(" Nineteen !");
                        break;

                }
	    }
        else                              // number has only one digit
	    {
            switch (lastDigit)
                {
                    case 1: Console.WriteLine("One!");
                        break;
                    case 2: Console.WriteLine("Two!");
                        break;
                    case 3: Console.WriteLine("Three!");
                        break;
                    case 4: Console.WriteLine("Four!");
                        break;
                    case 5: Console.WriteLine("Five!");
                        break;
                    case 6: Console.WriteLine("Six!");
                        break;
                    case 7: Console.WriteLine("Seven!");
                        break;
                    case 8: Console.WriteLine("Eight!");
                        break;
                    case 9: Console.WriteLine("Nine!");
                        break;
                }
	    }
    }
}

