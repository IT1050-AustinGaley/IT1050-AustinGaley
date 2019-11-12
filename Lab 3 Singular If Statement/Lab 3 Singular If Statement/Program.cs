using System;

namespace Lab3_Singular_If_Statement 
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

        }
    }
}