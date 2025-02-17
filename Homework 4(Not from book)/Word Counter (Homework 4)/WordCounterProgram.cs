// Written By Aaron Paatela
// 2/17/2025
// This is the Main Program for the Homework 4 question to make a method that takes a string and returns the word count.


namespace Word_Counter__Homework_4_
{
    internal class WordCounterProgram
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a string to count the words for: ");
            string myString = Console.ReadLine();

            int stringWordCount = WordCounterClass.CountWords(myString);

            Console.WriteLine($"That string contains {stringWordCount} words.");
            
        }
    }
}
