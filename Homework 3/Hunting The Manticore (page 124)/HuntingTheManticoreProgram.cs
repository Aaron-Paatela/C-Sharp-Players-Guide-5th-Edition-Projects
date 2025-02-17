// Written By Aaron Paatela
// 2/12/2025
// This is the Main Program for the Hunting The Manticore exercise
// in C# Players Guide 5th Edition on page 124


using System.Runtime.CompilerServices;

namespace Hunting_The_Manticore__page_124_
{
    public class HuntingTheManticoreProgram
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
            int testNum = Convert.ToInt32(Console.ReadLine());
            int manticoreLocation = int.MinValue;
            // Makes sure the manticore location is a valid number (0 to 100 inclusive)
            bool validNum = false;
            while (validNum == false)
            {
                if (testNum < 0 || testNum > 100)
                {
                    Console.WriteLine("Invalid Number. Please try again (0 through 100): ");
                    testNum = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                else
                {
                    manticoreLocation = testNum;
                    validNum = true;
                    continue;
                }
            }

            Console.Clear();

            HuntingTheManticoreClass aManticoreHunt = new HuntingTheManticoreClass(15, 10, 1, manticoreLocation);

            // initializing the game
            bool gameOver = false;
            Console.WriteLine("Player 2: It is your turn");
            while (gameOver == false)
            {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine($"STATUS: Round: {aManticoreHunt.CurrentRound}   City: {aManticoreHunt.CityHealth}/15" +
                    $"   Manticore: {aManticoreHunt.ManticoreHealth}/10");
                if (aManticoreHunt.CurrentRound % 5 == 0 && aManticoreHunt.CurrentRound % 3 == 0)
                {
                    Console.WriteLine("The Cannon is expected to deal 10 damage this turn.");
                }
                else if (aManticoreHunt.CurrentRound % 5 == 0 || aManticoreHunt.CurrentRound % 3 == 0)
                {
                    Console.WriteLine("The Cannon is expected to deal 3 damage this turn.");
                }
                else
                {
                    Console.WriteLine("The Cannon is expected to deal 1 damage this turn.");
                }
                Console.Write("Enter desired cannon range: ");
                int desiredRange = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(aManticoreHunt.CannonShot(desiredRange));
                aManticoreHunt.CurrentRound++;
                aManticoreHunt.CityHealth--;
                if (aManticoreHunt.ManticoreHealth <= 0)
                {
                    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
                    gameOver = true;
                    continue;
                }    
                else if (aManticoreHunt.CityHealth <= 0)
                {
                    Console.WriteLine("The Manticore has destroyed the city! Better luck next time!");
                    gameOver = true;
                    continue;
                }
                else
                {
                    continue;
                }




            }
        }
    }
}
