using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int cookies;
            int cookiesJar;

            Console.WriteLine("How many cookies are left in the jar?:");

           cookiesJar = 12;
            cookies = Convert.ToInt32(Console.ReadLine());

            if (cookies == cookiesJar)
                Console.WriteLine("It is True!");

            else
                Console.WriteLine("It is False!");
            // for a single selection statement, the program takes two or more values and compares them. After comparing, the program then uses logic to determine the output. The same can be said for while repetition statements. One major difference between the two is that the while-repetition statement will loop until a certain condition is met and for the single-selection statement as the name suggest, there is only one value either compared or inputted then the program ends.
        }
    }
}