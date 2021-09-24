using System;

namespace Lab1
{
    class LoopCounting
    {
        static void Main(string[] args)
        {

            int loop = 0; // track number of loops independtly of automatic for loop

            for (int x = 1; loop < 5; x++) //this took me so long to figure out, I don't think I ever used an independent counter in a for loop before
            {
                Console.WriteLine(x);

                if (x == 10) //if x = 10 start reversing
                {
                    for (int y = 10; y >= 1; y--)
                    {
                        Console.WriteLine(y);
                    }

                    //AFTER loop, set x to 0 and increment independent loop counter - x to 0 because it will x++ to 1 at the end of the exterior loop
                    x = 0;
                    loop++;
                }

            }
            



        }
    }
}
