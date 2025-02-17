// Written By Aaron Paatela
// 2/11/2025
// This is the Main Program for the Homework 3 problem to find the min and max of an array



namespace FindMinMax
{
    public class FindMinMaxProgram
    {
        public static void Main(string[] args)
        {
            FindMinMaxSolution solver = new FindMinMaxSolution();
            int[] output = solver.FindMinMax([1, 4532, 7, 56, 24, -1, 56, 2, 52, 543, 23]);

            Console.WriteLine($"Min: {output[0]}.");
            Console.WriteLine($"Max: {output[1]}.");
            
        }
    }
}
