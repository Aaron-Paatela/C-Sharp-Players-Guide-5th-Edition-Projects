// Writtten By Aaron Paatela
// 2/4/2025


using System.Xml.Serialization;

namespace Buying_Inventory__page_82_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creates our desired menu of items
            Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n");
            Console.WriteLine("4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies");

            // asks what item the user wants to look at
            Console.Write("What number do you want to see the price of? ");
            string input = Console.ReadLine();
            int ItemNumber = Convert.ToInt32(input);

            int GoldCost = 0;
            string ItemName = "";

            // Switch statement based on which item number is chosen
            switch (ItemNumber)
            {
                case 1:
                    GoldCost = 10;
                    ItemName = "Rope costs"; // "costs" included because some items will use 'cost' and some will use 'costs'
                    break;
                case 2:
                    GoldCost = 15;
                    ItemName = "Torches cost";
                    break;
                case 3:
                    GoldCost = 25;
                    ItemName = "Climbing Equipment costs";
                    break;
                case 4:
                    GoldCost = 1;
                    ItemName = "Clean Water costs";
                    break;
                case 5:
                    GoldCost = 20;
                    ItemName = "A Machete costs";
                    break;
                case 6:
                    GoldCost = 200;
                    ItemName = "A Canoe costs";
                    break;
                case 7:
                    GoldCost = 1;
                    ItemName = "Food Supplies cost";
                    break;

            }

            Console.WriteLine($"{ItemName} {GoldCost} gold.");
        }
    }
}
