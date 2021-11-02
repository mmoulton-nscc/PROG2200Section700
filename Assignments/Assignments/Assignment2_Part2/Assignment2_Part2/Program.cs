using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    public delegate void BalanceEventHandler(decimal theValue);




    class Program
    {
        static void Main(string[] args)
        {
            PiggyBank pb = new PiggyBank();
            BalanceLogger bl = new BalanceLogger();
            BalanceWatcher bw = new BalanceWatcher();

            // Triggering the balacedChanged event listener. 
            // That means this event is ready to implpement balanceLog method &
            // belanceWatch method once it is called from the setter of the m_bankBalance

            pb.balanceChanged += bl.balanceLog; // By implementing the balanceLog method
            pb.balanceChanged += bw.balanceWatch; // By implementing the balanceWatch method


            pb.negBalanceChanged += delegate (object sender, BalanceArgs e) //anonymous delegate for negative balance
            {
                if (e.balance < 0)
                {
                    Console.WriteLine("You've dropped below zero, your balance is {0}", e.balance);
                }
            };

            string theStr;

            

            do
            {
                while (true) //validation
                {
                    Console.WriteLine("How much to deposit?");

                    theStr = Console.ReadLine();
                    if (!theStr.Equals("exit"))
                    {

                        try //validation
                        {
                            decimal newVal = decimal.Parse(theStr);

                            pb.theBalance += newVal;
                        }
                        catch (Exception ex) //loop till numeric
                        {
                            Console.WriteLine("Please enter a numeric value");
                        }
                    }
                    else
                    {
                        break; //exit while loop if theStr = exit
                    }
                }
            } while (!theStr.Equals("exit"));
            Console.WriteLine("Your current balance after those transactions is: ${0}",pb.theBalance);
            Console.ReadLine();

        }
    }
}
