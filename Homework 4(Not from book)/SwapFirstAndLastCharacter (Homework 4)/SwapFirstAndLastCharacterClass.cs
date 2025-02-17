// Written By Aaron Paatela
// 2/17/2025
// This is the separate class for the Homework 4 exercise
// to swap the first and last character in a string
// unless the length of the string is less than two, 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapFirstAndLastCharacter__Homework_4_
{
    internal class SwapFirstAndLastCharacterClass
    {

        public static string SwapCharacters(string aString)
        {
            string message = "";
            if (aString.Length < 2)
            {
                message += "Incompatible";
            }
            else if (aString[0] == aString[^1])
            {
                message += "Two's a pair.";
            }
            else
            {

                // use substring to make a new string containing the first letter, the last letter, and the rest of the string.
                string firstLetter = aString.Substring(0, 1);
                string lastLetter = aString.Substring(aString.Length - 1, 1);
                string restOfString = aString.Substring(1, aString.Length - 2);
                // make the message with the last letter first, the rest of the string, then the first letter.
                message += lastLetter + restOfString + firstLetter;
            }
            return message;
        }
    }
}
