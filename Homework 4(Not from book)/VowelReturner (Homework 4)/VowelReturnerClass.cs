// Written By Aaron Paatela
// 2/17/2025
// This is the separate class for the Homework 4 exercise to 
// write a function that returns the first n vowels of a string.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelReturner__Homework_4_
{
    public class VowelReturnerClass
    {

        public static string FirstNVowels(string aString, int aNum)
        {
            string returnString = "";
            int i = 0;  // our number to increase by one every time through the while loop. 


                while (returnString.Length < aNum)
                {
                if (i == aString.Length)
                {
                    break;
                }
                else if (aString[i] == 'a' || aString[i] == 'e' || aString[i] == 'i' || aString[i] == 'o' || aString[i] == 'u')
                {
                    returnString += aString.Substring(i, 1);
                    i++;
                    continue;
                }
                else
                    {
                    i++;
                    }
                    
                
                }   
                if (returnString.Length < aNum)
                {
                    returnString = "invalid";
                }
        return returnString;
        }
    }
}
