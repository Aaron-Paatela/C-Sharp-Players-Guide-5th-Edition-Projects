// Written By Aaron Paatela
// 2/17/2025
// This is the separate class for the Homework 4 exercise to
// write a function that changes every letter in a string to the next letter


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLetterReplacer
{
    public class NextLetterReplacerClass
    {

        public static string Move(string aString)
        {
            string replacedString = "";
            
            for (int i = 0;  i < aString.Length; i++)
            {
                int encodingNum = aString[i]; // takes the integer value for the character at the index location in the string

                replacedString += Char.ConvertFromUtf32(encodingNum + 1); //appends the string we are returning with the letter that
                                                                          // corresponds to the number we got before +1
                                                                          // (the next letter in the table).
                                                                          // This is also why it wouldn't work for 'z'.
                                                                          // In the case of 'z', we would get back '{'.
                                                                          // In the case of 'Z', we would get back '['.
            }
            return replacedString;
        }
    }
}
