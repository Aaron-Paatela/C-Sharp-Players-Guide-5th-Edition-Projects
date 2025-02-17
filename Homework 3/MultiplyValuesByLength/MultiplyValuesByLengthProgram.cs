// Written By Aaron Paatela
// 2/11/2025
// This is the Main Program for the Homework 3 problem to multiply all values in an array by
// the amount of values in the given array (length).  



using System.Security.Cryptography.X509Certificates;

namespace MultiplyValuesByLength
{
    public class MultiplyValuesByLengthProgram
    {
        public static void Main(string[] args)
        {
            MultiplyValuesByLengthClass classInstance = new MultiplyValuesByLengthClass();

            int[] result = classInstance.MultiplyByLength([2, 3, 1, 0]);

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
