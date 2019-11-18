using System;

namespace Lab3_Singular_If_Statement 
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit = 35;
            int speed = 0;
            while (speed < 35)
            {
                Console.WriteLine(speed);
                speed = speed + 5;

            }
            if (speed > speedLimit) ;
            Console.WriteLine("Slow Down");
        }
    }
}