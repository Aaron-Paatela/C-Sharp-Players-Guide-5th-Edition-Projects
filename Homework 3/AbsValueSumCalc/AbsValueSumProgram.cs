// Written By Aaron Paatela
// 2/11/2025
// This is the Main Program for the Homework 3 problem to find the absolute value sum of
// an array of integers


using System.Security.Cryptography.X509Certificates;

namespace AbsValueSumCalc
{
    public class AbsValueSumProgram
    {
        public static void Main(string[] args)
        {
            AbsValueSumClass sumInstance = new AbsValueSumClass();

            int solution = sumInstance.GetAbsValue([-1, -2, -3, -4, 5, 6, 7]);

            Console.WriteLine(solution);
        }
    }
}
