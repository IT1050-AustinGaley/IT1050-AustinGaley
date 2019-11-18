using System;

namespace Lab_3_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {

            int tempCounter; // number of the grade to be entered next

            double fahrenheit; // grade value entered by the user
            double celsius;



            tempCounter = 1; // initialize the loop counter

            while (tempCounter <= 10)
            {
                Console.WriteLine("Enter temp:");
                fahrenheit = Convert.ToDouble(Console.ReadLine());
                celsius = (fahrenheit - 32d) * 5d / 9d;

                tempCounter = tempCounter + 1;

                if (celsius < 40)
                    Console.WriteLine("It is cold");
                if (celsius > 90)
                    Console.WriteLine("it is hot");

            }

        }
    }
}

