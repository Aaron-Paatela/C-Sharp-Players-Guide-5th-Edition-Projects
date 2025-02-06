namespace The_Replicator_of_D_To__page_94_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //initalize the first array
            int[] initialArray = new int[5];

            // asks the user for a number 5 times
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                initialArray[i] = num; //adds the number to the array in the desired index location
            }
            
            int[] copyArray = new int[5]; //initialize the copy array

            // loop to copy from original array to copy array
            for (int i = 0; i < 5; i++)
            {
                copyArray[i] = initialArray[i]; 
            }
            
            //prints the arrays on the console to show they are the same
            for (int item = 0; item < 5; item++)
            {
                Console.WriteLine($"Original array number: {initialArray[item]}, Copy array number: {copyArray[item]}");
            }
                
        }
    }
}
