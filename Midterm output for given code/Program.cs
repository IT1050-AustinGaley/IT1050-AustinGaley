using System;

namespace Midterm_output_for_given_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition

        }
    }
}
//  Output is a single "*" since this is a do-while
// Output in a regular while statment would be "* *" since it would loop twice until i was no longer < n