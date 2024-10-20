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

        Fundament fundament = new Fundament();

        fundament.CheckOddOrEven(5);

        string fact = "Um, turtles can breathe through their butts? -Olaf, the snowman";
        Console.WriteLine(fundament.GetAnInterestingFact(fact));

        fundament.SumTwoNumbers();

    }
}
