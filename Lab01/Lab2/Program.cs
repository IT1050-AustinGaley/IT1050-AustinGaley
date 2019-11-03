using System;

namespace Lab2
{
    class Program
    {       // Point of C# console application execution 
        static void Main(string[] args)
        {
            int number1;    //An Integer type variable is a whole number either positive or negative, a "double/floating-point" variable is a number with a decimal. Float or double typically go to the tenths place while the "decimal" goes up to the 29th digits place
            int number2;
            int product;
            Console.Write("Enter first integer:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second inteteger:");
            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2;
            Console.WriteLine("Product is {0}", product);

            Console.WriteLine("Hello World!\nFrom Austin Galey!");
        }   // A calling method requires the declaring the method as "public" that can be used outside the class declaration. After you would use the keyword "void" so the information is not returned if you were simply using "DisplayMessage()" 
            // To read the value of an instance variable, we create a method called GET accessor.
            // To assign a value to an instance variable, we use a method called a SET accessor.
            // A class houses the entirety of the methods listed. The class "Program" contains the methods of dipslaying a message and producing the product of two integers.
            // An object is something that needs to be designated in order for the class do anything with it. Our objects "number1" and "number2" were built as regular INT variables and then we had the class execute the method of obtaining the product from the two objects we created. Likewise, "product" was an object created for the "number1" and "number2" objects, but we had to tell product what to do as it would not have accomplished anything by simply typing "Console.WriteLine(Product is {0}", product;" 

    }

}
