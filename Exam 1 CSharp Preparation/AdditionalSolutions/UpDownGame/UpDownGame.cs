using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownGame
{
    class UpDownGame
    {
        static void Main()
        {
            Console.WriteLine(" Up Down Game!");
            Console.WriteLine(" Please select difficulty:");
            Console.WriteLine(" 1 for easy ");
            Console.WriteLine(" 2 for medium ");
            Console.WriteLine(" 3 for hard ");
            int difficulty  = int .Parse(Console.ReadLine());
            int low = 0;
            int top = 0;
            int guess = 0;
            switch (difficulty)
	        {
                case 1:  
                    low = 1;
                    top = 9;
                    guess = 3;
                    break;
                case 2:
                    low = 1;
                    top = 101;
                    guess = 15;
                    break;
                case 3:
                    low = 1;
                    top = 1001;
                    guess = 25;
                    break;
		        default:
                    return;
	        }
            
            Console.WriteLine(" Try to guess the number from 1 to {0}?", top);
            Random generated = new Random();

            int end = generated.Next(low, top);

            int counter = 1;
            while (counter <= guess)
            {

                Console.WriteLine("Enter your number: ");
                int userNumber;
                bool parseNumber = int.TryParse(Console.ReadLine(), out userNumber);
                if (!parseNumber)
                {
                    Console.WriteLine("Please enter valid number:" );
                    continue;
                }

                if (userNumber == end)
                {
                    Console.WriteLine("Congratulations! You Won!");
                    break;
                }
                else if (userNumber > end)
                {
                    Console.WriteLine(" Down! ");
                }
                else if (userNumber < end)
                {
                    Console.WriteLine(" Up! ");
                }
                Console.WriteLine(" Tries left: {0}", guess - counter);
                
                counter++;
            }
            if (counter > guess)
            {
                Console.WriteLine(" Sorry. No more trying! GAME OVER!");
            }
            Console.ReadLine();
        }
    }
}
