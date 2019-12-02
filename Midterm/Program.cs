using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int keepLooping = 1;
            while (keepLooping <= 100)
            {
               keepLooping--;
                Console.WriteLine(keepLooping);
            }
            
        }
    }
}
// Question 1: The three types of control structures are sequence structures, repitition structures, and selection structures. 
// Sequence structures: This structure as the name states as a specific sequence of actions that exectue in order to come up with a result such as adding to an amount to a total and then adding that instance to a counter. 
// Repitition structures: "While" is an example of a repitition statement.  A variable is assigned an initial value and then a line of code if done until a certain value is met for that variable 
// Selection structures: Selection statements such as "if" and "If....else" are examples of Selection structures. The program would determine if a set value was either "true" or "false" based on the user input and then submit "if" for a true setting or the "else" for a false setting.

