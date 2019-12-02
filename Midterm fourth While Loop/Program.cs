using System;

namespace Midterm_fourth_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 21)
            {
                x++;
                if (x % 2 == 0)
                    Console.Write("");
                else
                    Console.Write("{0} ", x);

            }

        }
    }
}
