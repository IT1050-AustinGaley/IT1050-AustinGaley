using System;

namespace Lab3_While_Loop__1_to_10_increment_by_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = 0;
           while (number < 11)
            {
                Console.WriteLine(number);
                number = number + 1;
            }
        }
    }
}
