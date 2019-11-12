using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int speed;

            Console.WriteLine("Enter Speed:");

            speedLimit = 35;
            speed = Convert.ToInt32(Console.ReadLine());

            if (speed > speedLimit)
                Console.WriteLine("SLOW DOWN");

            else
                Console.WriteLine("Thank you for obeying the speedlimit citizen!");


        }
    }
}