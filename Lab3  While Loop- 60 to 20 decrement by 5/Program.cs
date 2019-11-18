using System;

namespace Lab3__While_Loop__60_to_20_decrement_by_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = 60;
            while (number >= 20)
            {
                Console.WriteLine(number);
                number = number - 5;
            }
        }
    }
}
