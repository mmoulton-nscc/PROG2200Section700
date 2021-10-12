using System;

namespace ServerChat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run as Client vs Server
            while (true)
            {
                Console.WriteLine("Listening For Messages");

                //User Input Mode when I key pressed
                ConsoleKeyInfo userKey = Console.ReadKey(); //blocking statement

                //Display incoming message

                //Allow for input

                //Let user quit
                Console.WriteLine($"You Typed {userKey.Key}");
            }
            
        }
    }
}
