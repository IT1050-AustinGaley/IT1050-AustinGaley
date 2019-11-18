using System;

namespace Lab_3_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter degrees in Farhenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius;
            celsius = (fahrenheit - 32d) * 5d / 9d;

            if (fahrenheit > 90)
                Console.WriteLine("\nIt is Hot");
            if (fahrenheit < 40)
                Console.WriteLine("\nIt is Cold");

            Console.WriteLine("\nIt is");
            Console.Write(celsius);
            Console.WriteLine("\ndegrees in celsius");

        }
    }
}

