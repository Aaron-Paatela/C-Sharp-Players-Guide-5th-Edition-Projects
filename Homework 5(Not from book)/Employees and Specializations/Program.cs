// Written By Aaron Paatela
// 2/24/2025

//This is the Main Program used to test Homework 5 Problem 2

using System.Security.Cryptography.X509Certificates;

namespace Employees_and_Specializations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Engineer anEngineer = new Engineer("quantum physics", "Paul", 150_000);

            Console.WriteLine(anEngineer.ToString());

            Manager aManager = new Manager(10, "Frank", 200_000);

            Console.WriteLine($"\n{aManager.ToString()}");
        }
    }
}
