using System;

namespace Lab4_10_20_code_correction
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9;
                while (i < 20)
                 Console.WriteLine(i= i + 1);

           //int i = 10;
           //while (i < 21)
           //{
           //      Console.WriteLine(i);
           // }
           // this causes an infinite loop since "i" is not being incremented by 1 during the "while" process. This causes "i" to always be at the value 10 which is always less then 21 which causes the while loop to go forever


        }
    }
}
