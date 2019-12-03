using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            for (int m =0; m < months.Length; m++)
            {
                Console.WriteLine(months[m]);
            }


            string[] seasons = new string[4] { "Spring", "Summer", "Fall", "Winter" };
            for (int s = 0; s < seasons.Length; s++)
            {
                Console.WriteLine("\n{0}", seasons[s]);
            }

            int[] ranNum = new int[1000];
            Random random = new Random();
            int randomNumber;
                for(int counter = 0; counter < ranNum.Length; counter++)
                randomNumber = random.Next(0, 100);
            Console.WriteLine(ranNum[0]);

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

           
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();


        }
    }
}
// Question 1: p[0], p[1], p[2], p[3]
