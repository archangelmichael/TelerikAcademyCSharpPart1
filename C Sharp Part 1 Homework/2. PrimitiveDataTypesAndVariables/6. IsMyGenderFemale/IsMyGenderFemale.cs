using System;

class IsMyGenderFemale
{
    static void Main()
    {
        bool isFemale;
        string myGender;
        // enter gender until it is a valid value
        do
        {
            Console.Write("Please enter your gender: ");
            myGender = Console.ReadLine();
        } while ((myGender != "male") && (myGender != "female"));

        if (myGender == "female")
            isFemale = true;
        else
            isFemale = false;
        Console.WriteLine("Is your gender female? {0}",isFemale);
    }
}

