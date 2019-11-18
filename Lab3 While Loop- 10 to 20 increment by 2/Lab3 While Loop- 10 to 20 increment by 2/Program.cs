using System;

namespace Lab3_While_Loop__10_to_20_increment_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = 10;
            while (number <= 20)
            {
                Console.WriteLine(number);
                number = number + 2;
            }
        }
    }
}
