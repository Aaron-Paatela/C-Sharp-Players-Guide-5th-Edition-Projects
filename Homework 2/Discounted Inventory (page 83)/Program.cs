//Written by Aaron Paatela
// 2/4/2025


namespace Discounted_Inventory__page_83_
{
    //I've directly copied the whole Program class over from original "Buying Inventory" project.
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creates our desired menu of items
            Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n");
            Console.WriteLine("4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies");

            // asks what item the user wants to look at
            Console.Write("What number do you want to see the price of? ");
            string Input = Console.ReadLine();
            int ItemNumber = Convert.ToInt32(Input);

            Console.Write("What is your name?");
            string UserName = Console.ReadLine();

            // Asks the user their name


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

            if (UserName == "Aaron")  // If the name of the user is Aaron (me) goldcost is halved.
            {
                GoldCost /= 2;
            }
            // I've sneakily allowed myself to get a better discount sometimes
            // by using ints to floor the number, I could however have used doubles or floats and
            // ended up with .5 gold in some cases, maybe then 
            // converting somehow to be worth 5 silver to account for the remainder.
            
            Console.WriteLine($"{ItemName} {GoldCost} gold.");
        }
    }
}
