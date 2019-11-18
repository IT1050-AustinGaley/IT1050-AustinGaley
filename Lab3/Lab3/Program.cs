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
        }
    }
}