// Written By Aaron Paatela
// 2/17/2025
// This is the separate class for the Homework 4 exercise to 
// write a function that returns the first n vowels of a string.


namespace VowelReturner__Homework_4_
{
    public class VowelReturnerProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(VowelReturnerClass.FirstNVowels("sharpening skills", 3));

            Console.WriteLine(VowelReturnerClass.FirstNVowels("major league", 5));

            Console.WriteLine(VowelReturnerClass.FirstNVowels("hostess", 5));

        }
    }
}
