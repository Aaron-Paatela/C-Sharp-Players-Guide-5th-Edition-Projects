// Written By Aaron Paatela
// 2/5/2025


using System.Reflection.Metadata.Ecma335;

namespace The_Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Establishing our variables

            bool validNumber = false;
            int correctNumber = -1;
            bool guessedCorrectly = false;
            int numberGuess = -1;
            string stringNumGuess = "";


            // While loop asking user to enter a number and making sure a valid number was entered
            while (validNumber == false)
            {
                Console.Write("User 1, enter a number between 0 and 100: ");
                string userInput = Console.ReadLine();
                correctNumber = Convert.ToInt32(userInput);
                if (correctNumber < 0 || correctNumber > 100) // Checks whether the entered number is valid or not
                {
                    Console.WriteLine("number entered invalid, try again");
                    continue;
                }
                else
                {
                    validNumber = true; // Could also just use a break statement here
                    continue;
                }

                
            }
            Console.Clear();


            Console.Write("User 2, guess the number. ");
            stringNumGuess = Console.ReadLine();
            numberGuess = Convert.ToInt32(stringNumGuess);

            // While loop for number guesser
            while (guessedCorrectly == false)
            {
                if (numberGuess < correctNumber)
                {
                    Console.WriteLine($"{numberGuess} is too low");
                    Console.Write("What is your next guess?");
                    stringNumGuess = Console.ReadLine();
                    numberGuess = Convert.ToInt32(stringNumGuess);
                    continue;
                }
                else if (numberGuess > correctNumber)
                {
                    Console.WriteLine($"{numberGuess} is too high");
                    Console.Write("What is your next guess?");
                    stringNumGuess = Console.ReadLine();
                    numberGuess = Convert.ToInt32(stringNumGuess);
                    continue;
                }
                else if (numberGuess == correctNumber)
                {
                    Console.WriteLine($"You guessed the number!");
                    guessedCorrectly = true;
                    continue;
                }
                
            }
        }
    }
}
