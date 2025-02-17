// Written By Aaron Paatela
// 2/11/2025
// This is the Main Program for the Homework 3 problem to return the smaller number between 2 strings



namespace SmallerNumberComparer
{
    public class SmallerNumberProgram
    {
        public static void Main(string[] args)
        {

            SmallerNumberClass classInstance = new SmallerNumberClass();

            string result = classInstance.GetSmallerNum("120", "2");

            Console.WriteLine(result);
            
        }
    }
}
