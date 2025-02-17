// Written By Aaron Paatela
// 2/11/2025
// This is the Main Program for the Homework 3 problem to multiply all values in an array by
// the amount of values in the given array (length).



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyValuesByLength
{
    public class MultiplyValuesByLengthClass
    {
        // methods
        public int[] MultiplyByLength(int[] arr)
        {
            int[] multipliedArray = new int[arr.Length];
            int multiplier = arr.Length;
            foreach (int i in arr)
            {
                multipliedArray[i] = arr[i] * multiplier;
            }

            return multipliedArray;
        }
    }
}
