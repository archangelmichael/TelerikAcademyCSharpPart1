using System;

class BonusScore
{
    static void Main(string[] args)
    {
        /*  Write a program that applies bonus scores to given scores in the range [1..9]. 
         * The program reads a digit as an input. If the digit is between 1 and 3, 
         * the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
         * if it is between 7 and 9, multiplies it by 1000. If it is zero or 
         * if the value is not a digit, the program must report an error.  
		Use a switch statement and at the end print the calculated new value in the console. */
        uint finalScore = 0;
        try
        {
            Console.WriteLine("Enter Score: ");
            uint score = uint.Parse(Console.ReadLine());
            finalScore = score;
        }
        catch (FormatException)
        {
            Console.WriteLine("Please, input valid number value.");
            return;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Please, input valid number.");
            return;
        }

        switch (finalScore)
        {
            case 1:
            case 2:
            case 3:
                finalScore *= 10;
                Console.WriteLine(" The Final Score is: {0} points !", finalScore);
                break;
            case 4:
            case 5:
            case 6:
                finalScore *= 100;
                Console.WriteLine(" The Final Score is: {0} points !", finalScore);

                break;
            case 7:
            case 8:
            case 9:
                finalScore *= 1000;
                Console.WriteLine(" The Final Score is: {0} points !", finalScore);
                break;
            default: Console.WriteLine("Error! Wront Input Score !");
                break;
        }
    }
}

