// Written By Aaron Paatela
// 2/17/2025
// This is the Main Program for the Homework 4 exercise to
// create a function that takes a string and returns true or false, depending on whether the characters
// are in order or not.  

// As a side note, since this program compares the ASCII values for the given letter, it will determine that any capital letter
// is 'valued' at less than any lower case letter.  Thus, Y < Z < a.  numbers will also be 'valued' less han either.
// So this particular function will work best if the individual string only contains ints 0-9, letters A-Z, or letters a - z.



namespace IsInOrder_Homework_4_
{
    public  class IsInOrderProgram
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine(IsInOrderClass.CheckOrder("abc"));
            Console.WriteLine(IsInOrderClass.CheckOrder("cba"));
            Console.WriteLine(IsInOrderClass.CheckOrder("123"));
            Console.WriteLine(IsInOrderClass.CheckOrder("321"));
            Console.WriteLine(IsInOrderClass.CheckOrder("edabit"));
            Console.WriteLine(IsInOrderClass.CheckOrder("xyzz"));


        }
    }
}
