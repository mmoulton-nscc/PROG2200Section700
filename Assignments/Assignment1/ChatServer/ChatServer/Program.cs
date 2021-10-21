using ChatLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ServerChat
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("-server")) //args[0] == -server
            {
                Console.WriteLine("Server");
                Server server = new Server();
            }
            else
            {
                Console.WriteLine("Client");
                Client client = new Client();
            }
            Console.ReadKey();
            //Run as Client vs Server
            while (true)
            {
                Console.WriteLine("Listening For Messages");

                if (Console.KeyAvailable)
                {
                    //User Input Mode when I key pressed
                    ConsoleKeyInfo userKey = Console.ReadKey(); //blocking statement

                    if (userKey.Key == ConsoleKey.I)
                    {
                        Console.WriteLine("I Pressed >>");
                        Console.ReadLine();
                        //break;
                    }
                    else
                    {
                        Console.WriteLine($"You Typed {userKey.Key}");
                        Thread.Sleep(600);
                    }

                    //Display incoming message

                    //Allow for input

                    //Let user quit
                    
                }
            }
            
        }
    }
}
