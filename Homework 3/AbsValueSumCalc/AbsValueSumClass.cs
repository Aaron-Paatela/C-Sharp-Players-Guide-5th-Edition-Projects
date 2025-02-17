// Written By Aaron Paatela
// 2/11/2025
// This is the separate class for the Homework 3 problem to find the absolute value sum of
// an array of integers



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsValueSumCalc
{
    public class AbsValueSumClass
    {
        // methods
        public int GetAbsValue(int[] ints)
        {
            int sum = 0;
            foreach (int i in ints)
            {
                sum += Math.Abs(i);
            }
            return sum;
        }

    }
}
