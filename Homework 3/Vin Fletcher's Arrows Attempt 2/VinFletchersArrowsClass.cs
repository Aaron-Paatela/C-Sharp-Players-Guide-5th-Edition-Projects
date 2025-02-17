// Written By Aaron Paatela
// 2/16/2025
// This is the separate class for the Homework 3 Vin Fletcher's Arrows exercise
// in C# Player's Guide 5th edition on page 153



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vin_Fletcher_s_Arrows_Attempt_2
{
    public class VinFletchersArrowsClass
    {

        // variables
        public Fletching fletching;
        public ArrowHead arrowHead;
        public float length; 


        // methods

        public float GetCost()
        {
            float totalcost = (int)arrowHead + (int)fletching + (length * .05f);
            return totalcost;
        }




        // Constructors

        public VinFletchersArrowsClass(ArrowHead _arrowHead, Fletching _fletch, float _length)
        {
            this.arrowHead = _arrowHead;
            this.fletching = _fletch;
            this.length = _length;
        }
    }


}
