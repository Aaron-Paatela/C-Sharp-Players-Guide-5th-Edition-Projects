// Written By Aaron Paatela
// 2/17/2025
// This is the separate class for the Homework 4 exercise to
// create a function that takes a string and returns true or false, depending on whether the characters
// are in order or not. 


// As a side note, since this program compares the ASCII values for the given letter, it will determine that any capital letter
// is 'valued' at less than any lower case letter.  Thus, Y < Z < a.  So this particular function will work best if the individual
// string only contains ints 0-9, letters A-Z, or letters a - z.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsInOrder_Homework_4_
{
    public class IsInOrderClass
    {

        public static bool CheckOrder(string aString)
        {
            bool isInOrder = true;
            for (int i = 1; i < aString.Length; i++)
            {
                char c = aString[i];
                char d = aString[i - 1];
                // Compare the ascii values, if the current ascii value being checked is less than the one before it, 
                // then the string must not be in order.  
                if (c < d)
                {
                    isInOrder = false;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return isInOrder;
        }
    }
}
