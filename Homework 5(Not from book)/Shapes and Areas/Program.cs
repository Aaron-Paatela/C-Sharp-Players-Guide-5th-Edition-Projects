// Written By Aaron Paatela
// 2/24/2025

// This is the Main Program used to test Homework 5 Problem 3


namespace Shapes_and_Areas
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Rectangle aRectangle = new Rectangle(2, 4, "blue");

            Console.WriteLine($"Rectangle\n{aRectangle.ToString()}");

            Circle aCircle = new Circle(2, "yellow");

            Console.WriteLine($"\nCircle\n{aCircle.ToString()}");
            
        }
    }
}
