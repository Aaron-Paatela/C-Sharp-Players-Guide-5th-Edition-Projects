// Written By Aaron Paatela
// 2/24/2025

// This is the Main Program used to test Homework 5 problem 1


using System.Security.Cryptography.X509Certificates;

namespace Vehicles_and_Cars
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Motorcycle aMotorCycle = new Motorcycle(true, "Ducati", "Streetfighter", 2024);

            Console.WriteLine(aMotorCycle.ToString());

            Car aCar = new Car(2, "Lamborghini", "Countash", 2024);

            Console.WriteLine(aCar.ToString());

        }
    }
}
