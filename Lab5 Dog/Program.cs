using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Dog
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.name = "Fido";


            // To do: uncomment the following lines of code to call the methods
            myDog.bark();
            Console.ReadLine();
        }
        private static void bark()
        {
            Console.WriteLine("{0} is Barking...");
        }

        private static void doTrick()
        {
            //trick name
            Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}",)
        }
    }
}
