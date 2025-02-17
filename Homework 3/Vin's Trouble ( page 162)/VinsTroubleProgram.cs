// Written By Aaron Paatela
// 2/16/2025
// This is the Main Program for the Homework 3 Vin's Trouble exercise
// in C# Player's Guide 5th edition on page 162

// I've essentially used the same code as before, since the only thing the new problem
// asks you to do is make the class variables private and then make gets and sets for them on
// the previous Vin Fletcher's Arrows problem.  

namespace Vin_s_Trouble___page_162_
{
    internal class VinsTroubleProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Here is our menu for customizing your own arrows!\n");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Shaft length: Anywhere from 60 to 100 cm, 0.05g per cm");
            Console.WriteLine("Arrowheads: Steel - 10g , Wood - 3g, Obsidian - 5g");
            Console.WriteLine("Fletching: Plastic - 10g, TurkeyFeather - 5g, GooseFeather - 3g");
            Console.WriteLine("---------------------------------------------------------");


            Console.Write("\nWhat type of arrowhead would you like? ");
            Enum.TryParse(Console.ReadLine(), out ArrowHead desiredArrowHead); // Trying to see if the entered value matches
                                                                               // an enum, then giving back the value if it does.


            Console.Write("What type of Fletching would you like? ");          // Same tryparse used here,
            Enum.TryParse(Console.ReadLine(), out Fletching desiredFletching); // This is where the space matters

            Console.Write("What length would you like the arrow shafts to be? ");
            float desiredLength = Convert.ToSingle(Console.ReadLine());
            bool validLength = false;
            while (validLength == false)
            {
                if (desiredLength < 60 || desiredLength > 100)
                {
                    Console.Write($"That is not a valid number. Please enter a number between 60 and 100. ");
                    desiredLength = Convert.ToSingle(Console.ReadLine());
                    continue;
                }
                else
                {
                    validLength = true;
                    continue;
                }
            }
            Vin_sTroubleClass aNewArrow = new Vin_sTroubleClass(desiredArrowHead, desiredFletching, desiredLength);

            Console.WriteLine($"The total cost will be {aNewArrow.GetCost()} gold.");


        }
    }
    public enum ArrowHead
    {
        Steel = 10,
        Wood = 3,
        Obsidian = 5
    }
    public enum Fletching
    {
        Plastic = 10,
        TurkeyFeather = 5,
        GooseFeather = 3
    }
}
