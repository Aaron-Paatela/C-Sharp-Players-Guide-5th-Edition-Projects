namespace The_Magic_Cannon__page_89_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("COMBINED BLAST!");
                    
                }
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fire");
                    
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Electric");
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Normal");
                    
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
