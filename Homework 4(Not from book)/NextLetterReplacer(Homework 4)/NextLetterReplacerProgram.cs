// Written By Aaron Paatela
// 2/17/2025
// This is the Main Program for the Homework 4 exercise to
// write a function that changes every letter in a string to the next letter

namespace NextLetterReplacer
{
    public class NextLetterReplacerProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(NextLetterReplacerClass.Move("hello"));

            Console.WriteLine(NextLetterReplacerClass.Move("bye"));

            Console.WriteLine(NextLetterReplacerClass.Move("welcome"));

        }
    }
}
