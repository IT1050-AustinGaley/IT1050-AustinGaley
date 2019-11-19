using System;

namespace Lab4
{
    class Program
    {
        public static void Main(string[] args)
        {
            
                int i;
            for (i = 1; i <= 100; ++i)
                if (i % 2 == 0)
                    Console.Write("\n{0} it is even\n ", i);
                else
                    Console.WriteLine("\n{0} is is odd\n ", i);

      

            // Question 1: The 4 basic elements of counter-controlled repetition are a control variable which is also known as the loop counter, the initial value of the control variable, the increment or decrement by which the loop executes, the loop continuation condition that determines if the loop should continue executing or not

            // Question 2: While loops and for repetition statements are very similar in the aspect that we are creating a program to continuously repeat a process to complete to a certain condition. For repetition statements are more dynamic than a standard while loop stating that for a designated counter, if certain conditions are met/not met- there is a subsequent command or process in place after the logic

            // Question 3: A do while tests the loop conditons after executing the loop body which means that it will always proces at least once. This can sometimes be easier to read if errors come across in coding


        }
    }
}
