// Written By Aaron Paatela
// 2/17/2025
// This is the separate class for the Homework 4 question to make a method that takes a string and returns the word count.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Counter__Homework_4_
{
    public class WordCounterClass
    {
        // Since I've become more familiar with memory and the heap, I looked online to see what would be a good way to 
        // do this without splitting our string into a bunch of strings that end up on the heap and take up memory. 
        public static int CountWords(string aString)
        {
            // initialize our word count and our index location to iterate through the string
            int wordCount = 0;
            int indexLocation = 0;

            // move the index location past any whitespace at the beginning of the string. 
            while (indexLocation < aString.Length && char.IsWhiteSpace(aString[indexLocation]))
            {
                indexLocation++;
            }
            // while the index location is less than the word length
            while (indexLocation < aString.Length)
            {
                // move the index location along until the character at the index location is white space again.  
                while ( indexLocation < aString.Length && !char.IsWhiteSpace(aString[indexLocation]))
                {
                    indexLocation++;
                }
                // add 1 to the word count
                wordCount++;
                // move the index location through the white space again until it gets to the next word
                while (indexLocation < aString.Length && char.IsWhiteSpace(aString[indexLocation]))
                {
                    indexLocation++;
                }
            }
            return wordCount;
        }
    }
}
