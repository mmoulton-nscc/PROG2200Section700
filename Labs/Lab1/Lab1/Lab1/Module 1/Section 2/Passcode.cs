using System;

namespace Lab1
{
    class Passcode
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your password:");
            var pass = Console.ReadLine();

            if (pass == "secret")
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Incorrect Password - Access Denied");
            }
        }
    }
}
