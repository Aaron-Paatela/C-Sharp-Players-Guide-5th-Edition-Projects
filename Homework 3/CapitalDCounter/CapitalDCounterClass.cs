// Written By Aaron Paatela
// 02/11/2025
// This is the separate class for the Homework 3 problem to count the number of capital D characters
// in a string. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalDCounter
{
    public class CapitalDCounterClass
    {
        // methods
        public int CountDs(string astring)
        {
            int DCount = 0;
            foreach (char c in astring)
            {
                if (c == 'D')
                {
                    DCount++;
                }    
            }
            return DCount;
        }

    }
}
