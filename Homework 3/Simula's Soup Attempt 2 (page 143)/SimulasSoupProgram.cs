// Written By Aaron Paatela
// 2/15/2025
// This is the Main Program for the Homework 3 Simula's Soup exercise
// in C# Player's Guide 5th edition on page 143


namespace Simula_s_Soup_Attempt_2__page_143_
{
    public class SimulasSoupProgram
    {
        public static void Main(string[] args)
        {
            //Provide the menu
            Console.WriteLine("Here is the style, Main ingredient and seasoning options you can choose from:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Style: soup, stew, gumbo");
            Console.WriteLine("Main Ingredient: mushrooms, chicken, carrots, potatoes");
            Console.WriteLine("Kinds of seasoning: spicy, salty, sweet");
            Console.WriteLine("----------------------------------------");

            // user gives desired options
            Console.Write("What style of food would you like? ");
            string desiredStyle = Console.ReadLine();
            Console.Write("What would you like for your main ingredient? ");
            string desiredIngredient = Console.ReadLine();
            Console.Write("What type of seasoning would you like? ");
            string desiredSeasoning = Console.ReadLine();

            // Make a "Soup" with the desired options
            var DesiredSoup = SimulasSoupClass.MakeASoup(desiredStyle, desiredIngredient, desiredSeasoning);


            // Present the "Soup" to the user
            Console.WriteLine($"\nHere is your {DesiredSoup.Item3} {DesiredSoup.Item2} {DesiredSoup.Item1}!");

        }
    }
}
