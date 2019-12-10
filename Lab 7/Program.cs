using System;

public class Book
{
    public void DisplayMessage(string bookAuthorAndDate)
    {
        int x;
   
        Console.WriteLine("\nRe-enter book number for author of the corresponding book");
        x = Convert.ToInt32(Console.ReadLine());


        if (x == 0)
            Console.WriteLine("\nThis book's author is: Herman Melville, published in 1851");
        if (x == 1)
            Console.WriteLine("\nThis book's author is: Albert Camus, published in 1956");
        if (x == 2)
            Console.WriteLine("\nThis book's author is: Charles Dickens, published in 1861");
    }

    public class BookTest
    {
        public static void Main(string[] args)
        {
            string[] nameOfBook = new string[3] { "Moby Dick", "The Fall", "Great Expectations" };
            Book myBook = new Book();

            Console.WriteLine("Which Book would you like to select? 0, 1, or 2?");


            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(nameOfBook[x]);

            myBook.DisplayMessage(nameOfBook[x]);

            
        }
    }

}
// Data Abstraction is when the client does not know how the specific code works, but understands the intent or purpose of the code.
// Composition is using has-a relationship. For this Book class, you could have specified the individual variables and set up each separate string to correspond based on user entry 
// Public lists that object available for the entire class, private lists that object for only a specific class. Utilizing private variables in conjunction with public ones, we can simplify the amount of space used in code making it easier to read.
// If we were to set up two new constructor methods instead we would have been utilizing the "Divide and Conquer" method.
// before adding the constructor method, one is created by default which is listed at"0"