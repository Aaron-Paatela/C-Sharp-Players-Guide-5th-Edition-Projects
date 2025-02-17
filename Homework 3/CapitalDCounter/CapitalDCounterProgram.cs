// Written By Aaron Paatela
// 02/11/2025
// This is the Main Program for the Homework 3 problem to count the number of capital D characters
// in a string.  



namespace CapitalDCounter
{
    public class CapitalDCounterProgram
    {
        public static void Main(string[] args)
        {
            CapitalDCounterClass aDCounter = new CapitalDCounterClass();

            string myString = "There are DDDDD 6 D's in this string.";

            Console.WriteLine($"The number of capital Ds in '{myString}' is {aDCounter.CountDs(myString)}.");
        }
    }
}
