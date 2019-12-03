using System;

namespace Midterm_Let_s_Go_Outside
{
    class Program
    {
        static void Main(string[] args)
        {
            string icyRain;
            string tornadoWarning;
           

            Console.WriteLine("Let's Go Outside!");
            Console.WriteLine("What's the weather like? Is it icy?");
            icyRain = Console.ReadLine();

            if (icyRain == "yes")
                Console.WriteLine("There's too much sleet to go out today");
            else
                Console.WriteLine("is it windy?");
                tornadoWarning = Console.ReadLine();
            if (tornadoWarning == "yes")
                Console.WriteLine("There's a possible tornado warning for today, lets stay indoors");
            else
                Console.WriteLine("Time to go outside!");
           

             

        }
    }
}

