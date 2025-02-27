// Written By Aaron Paatela
// 2/27/2025

// This is the Main Program to test Homework 5 Problem 5


namespace Library_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book aBook = new Book("Moby Dick", "Herman Melville", 1851);
            Console.WriteLine(aBook.ToString());

            EBook anEbook = new EBook("The Old Man and the Sea", "Ernest Hemingway", 1952, 84.2);
            Console.WriteLine($"\n{anEbook.ToString()}");

            PrintedBook aPrintedBook = new PrintedBook("The Return Of The King", "J.R.R Tolkien", 1955, 416);
            Console.WriteLine($"\n{aPrintedBook.ToString()}");

        }
    }
}
