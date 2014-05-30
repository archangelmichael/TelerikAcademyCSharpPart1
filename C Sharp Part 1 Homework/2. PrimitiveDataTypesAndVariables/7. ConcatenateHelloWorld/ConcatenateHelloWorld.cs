using System;

class ConcatenateHelloWorld
{
    static void Main()
    {
        string greeting = "Hello";
        string noun = "World!";
        object helloGreeting = greeting + " " + noun;
        Console.WriteLine(helloGreeting);
        string alltogether = (string)helloGreeting;
        Console.WriteLine(alltogether);
    }
}

