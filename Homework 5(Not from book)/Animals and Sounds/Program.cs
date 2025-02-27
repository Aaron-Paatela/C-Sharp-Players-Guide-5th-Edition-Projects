// Written By Aaron Paatela
// 2/26/2025

// This is the Main program to test Homework 5 Problem 4.  



using System.Runtime.CompilerServices;

namespace Animals_and_Sounds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cat aCat = new Cat("Sprinkles");

            Console.WriteLine(aCat.ToString());

            Dog aDog = new Dog("Rex");

            Console.WriteLine($"\n{aDog.ToString()}");

            Animal anAnimal = new Animal("Frank");

            Console.WriteLine($"\n{anAnimal.ToString()}");
        }
    }
}
