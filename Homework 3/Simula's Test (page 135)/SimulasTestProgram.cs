// Written By Aaron Paatela
// 2/14/2025
// This is the Main Program for the Homework 3 Simula's Test exercise
// in C# Player's Guide 5th edition on page 135


namespace Simula_s_Test__page_135_
{
    public class SimulasTestProgram
    {
        public static void Main(string[] args)
        {

            SimulasTestClass aChest = new SimulasTestClass(SimulasTestClass.ChestState.locked);
            bool quitCommand = false;

            Console.WriteLine("Enter 'q' or 'quit' at any time to exit the loop.");
            Console.WriteLine("Valid commands are: lock, unlock, open, close");
            Console.WriteLine("----------------------------------------------------\n");

            while (quitCommand == false)
            {
                Console.Write($"The chest is {aChest.currentChestState}. ");
                Console.Write("What would you like to do? ");
                string response = Console.ReadLine();
                if (response == "quit" || response == "q")
                {
                    Console.WriteLine("Thanks for playing!");
                    quitCommand = true;
                    continue;
                }
                Console.WriteLine($"{aChest.OpenCloseLockEnumLoop(response)}");
            }





        }

        
    }
}
