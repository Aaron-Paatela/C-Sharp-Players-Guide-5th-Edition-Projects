// Written By Aaron Paatela
// 2/16/2025
// This is the Main Program for the Homework 3 Vin Fletcher's Arrows exercise
// in C# Player's Guide 5th edition on page 153

// In your response, make sure your enter GooseFeather or TurkeyFeather instead of Turkey Feather or Goose Feather
// This is because instead of doing a switch converting string to enum values, I directly try to parse the entered value to
// see if it matches a given value inside the enum.  



using System.ComponentModel.Design;

namespace Vin_Fletcher_s_Arrows_Attempt_2
{
    public class VinFletchersArrowsProgram
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

            VinFletchersArrowsClass aNewArrow = new VinFletchersArrowsClass(desiredArrowHead, desiredFletching, desiredLength);

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
