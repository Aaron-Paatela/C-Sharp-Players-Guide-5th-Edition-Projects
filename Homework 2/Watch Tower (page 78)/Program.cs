// Written By Aaron Paatela
// 2/4/2025


namespace Watch_Tower__page_78_
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // User x-axis and y-axis input in relation to the tower location
            // -x values == westward, +x values == eastward
            // -y values == southward, +y values == northward
            Console.Write("What is the enemy locations x axis value? ");
            string xInput = Console.ReadLine();
            int xAxisNum = Convert.ToInt32(xInput);

            Console.Write("\nWhat is the enemy locations y axis value? ");
            string yInput = Console.ReadLine();
            int yAxisNum = Convert.ToInt32(yInput);


            //Direction if and nested if statements to determine direction based on input
            if (xAxisNum < 0)
            {
                if (yAxisNum > 0)
                {
                    Console.WriteLine("The enemy is to the NorthWest!");
                }
                else if (yAxisNum == 0)
                {
                    Console.WriteLine("The enemy is to the West!");
                }
                else if (yAxisNum < 0)
                {
                    Console.WriteLine("The enemy is to the SouthWest!");
                }
            }
            if (xAxisNum == 0)
            {
                if (yAxisNum > 0)
                {
                    Console.WriteLine("The enemy is to the North!");
                }
                else if (yAxisNum == 0)
                {
                    Console.WriteLine("The enemy is right on top of us!");
                }
                else if (yAxisNum < 0)
                {
                    Console.WriteLine("The enemy is to the South!");
                }
            }
            if (xAxisNum > 0)
            {
                if (yAxisNum > 0)
                {
                    Console.WriteLine("The enemy is to the NorthEast!");
                }
                else if (yAxisNum == 0)
                {
                    Console.WriteLine("The enemy is to the East!");
                }
                else if (yAxisNum < 0)
                {
                    Console.WriteLine("The enemy is to the SouthEast!");
                }
            }
        }
    }
}
