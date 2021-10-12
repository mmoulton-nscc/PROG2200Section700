using System;

namespace ServerChat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run as Client vs Server
            Console.WriteLine("Listening For Messages");

            //User Input Mode when I key pressed
            var userKey = Console.ReadKey();

            //Display incoming message

            //Allow for input

            //Let user quit
            Console.WriteLine($"You Typed {userKey.Key}");
        }
    }
}
