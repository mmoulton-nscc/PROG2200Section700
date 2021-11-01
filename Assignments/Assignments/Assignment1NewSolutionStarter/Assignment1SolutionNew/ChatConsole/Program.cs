using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatLib;

namespace ChatConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Console.ReadLine();
            if (args.Contains("-server"))
            {
                Server server = new Server();
            }
            else
            {
                Client client = new Client();
            }

        }
    }
}
