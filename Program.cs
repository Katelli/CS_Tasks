namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

        Console.WriteLine("\n");

        // Create instance
        Fundament fundament = new Fundament();

        // Odd or even
        fundament.CheckOddOrEven(5);

        Console.WriteLine("\n");

        // Interesting fact
        string fact = "Um, turtles can breathe through their butts? -Olaf, the snowman";
        Console.WriteLine(fundament.GetAnInterestingFact(fact));

        Console.WriteLine("\n");

        // Sum two numbers
        fundament.SumTwoNumbers();

        Console.WriteLine("\n");

        // Sum two numbers of a given type
        Console.WriteLine($"The sum of 5.5 + 6.8 is {fundament.SumTwoNumbersOfGivenType(5.5, 6.8)}");

        Console.WriteLine("\n");

        // Fibonnaci
        fundament.PrintFibonnaciSeries(5);

        Console.WriteLine("\n");

        // Reverse string
        Console.WriteLine(fundament.ReverseString("Hello"));

    }
}
