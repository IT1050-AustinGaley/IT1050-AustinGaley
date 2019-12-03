using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            Console.WriteLine(months[0]);
            Console.WriteLine(months[1]);
            Console.WriteLine(months[2]);
            Console.WriteLine(months[3]);
            Console.WriteLine(months[4]);
            Console.WriteLine(months[5]);
            Console.WriteLine(months[6]);
            Console.WriteLine(months[7]);
            Console.WriteLine(months[8]);
            Console.WriteLine(months[9]);
            Console.WriteLine(months[10]);
            Console.WriteLine(months[11]);

            string[] seasons = new string[4] { "Spring", "Summer", "Fall", "Winter" };
            Console.WriteLine("\n{0}",seasons[0]);
            Console.WriteLine(seasons[1]);
            Console.WriteLine(seasons[2]);
            Console.WriteLine(seasons[3]);

            int[] ranNum = new int[1000];
            Random random = new Random();
            int randomNumber;
                for(int counter = 0; counter < ranNum.Length; counter++)
                randomNumber = random.Next(0, 100);
            Console.WriteLine(ranNum[0]);

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 1;
            while (i < names.Length)
            {
                i++;

                Console.WriteLine("\n{0}", names[0]);
            }



        }
    }
}
// Question 1: p[0], p[1], p[2], p[3]
