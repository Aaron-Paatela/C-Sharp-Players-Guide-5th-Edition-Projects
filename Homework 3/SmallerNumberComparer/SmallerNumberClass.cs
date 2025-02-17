// Written By Aaron Paatela
// 2/11/2025
// This is the separate class for the Homework 3 problem to return the smaller number between 2 strings



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNumberComparer
{
    public class SmallerNumberClass
    {

        // methods
        
        public string GetSmallerNum(string num1, string num2)
            // This method probably warrants explanations for each statement
        {
            // if one string is shorter than the other, the shorter string is always a lower number
            // 100 will always be more than any number 1 - 99. 
            if (num1.Length < num2.Length)
            {
                return num1;
            }
            else if (num2.Length < num1.Length)
            {
                return num2;
            }
            else
            {
                // If the numbers are equal in length, you compare each number one by one
                // This works without conversion because in the encoding, each number 0 - 9
                // is valued lower than the one above it.  In other words,
                // the value for 0 < value for 1 < value for 2
                // I had to look this up to figure out how I could compare the numbers
                // without converting to integers.
                for (int i = 0; i < num1.Length; i++)
                {
                    if (num1[i] < num2[i])
                    {
                        return num1;
                    }
                    else if (num1[i] >  num2[i])
                    {
                        return num2;
                    }
                }
                // If the length is the same and each individual ASCII number is never < or >
                // when comparing to the other, you have the same number. So return whichever one you want.
                return num1;
            }
        }
    }
}
