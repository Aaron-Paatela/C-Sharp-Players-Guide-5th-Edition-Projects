// Written By Aaron Paatela
// 2/11/2025
// This is the separate class for the Homework 3 problem to find the min and max of an array



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinMax
{
    public class FindMinMaxSolution
    {
        // methods
        public int[] FindMinMax(int[] arr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (int i in arr)
            {
                if( i < min)
                {
                    min = i;
                }
                if ( i > max)
                { 
                    max = i;
                } 
                    
            }
            return [min, max];
        }
    }
}
