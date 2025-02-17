// Written By Aaron Paatela
// 2/17/2025
// This is the separate class for the Homework 4 exercise
// to swap the first and last character in a string
// unless the length of the string is less than two,



namespace SwapFirstAndLastCharacter__Homework_4_
{
    internal class SwapFirstAndLastCharacterProgram
    {
        public static void Main(string[] args)
        {
            string exampleString = "Cat, dog, and mouse.";

            string flippedString = SwapFirstAndLastCharacterClass.SwapCharacters(exampleString);

            string exampleTwoPair = "ada";
            string flippedPair = SwapFirstAndLastCharacterClass.SwapCharacters(exampleTwoPair);

            string OneLetterExample = SwapFirstAndLastCharacterClass.SwapCharacters("z");

            Console.WriteLine(flippedString);

            Console.WriteLine(flippedPair);

            Console.WriteLine(OneLetterExample);
        }
    }
}
