using System;

namespace Lab1
{
    class MultiplelChoiceQuestions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("Welcome, {0}", name);

            Console.WriteLine("What's your age?");
            var age = Console.ReadLine();

            Console.WriteLine("You are {0}", age);

            Console.WriteLine("What was your birth month?");
            var month = Console.ReadLine();

            Console.WriteLine("You were born in {0}", month);

            //extra questions
            Console.WriteLine("What is your favorite food?");
            var food = Console.ReadLine();

            Console.WriteLine("Your favorite food is {0}", food);

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("You favorite color is {0}", color);
        }
    }
}
