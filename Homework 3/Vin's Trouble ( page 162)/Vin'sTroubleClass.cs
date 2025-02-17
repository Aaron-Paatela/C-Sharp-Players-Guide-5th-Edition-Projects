// Written By Aaron Paatela
// 2/16/2025
// This is the Main Program for the Homework 3 Vin's Trouble exercise
// in C# Player's Guide 5th edition on page 162

// I've essentially used the same code as before, since the only thing the new problem
// asks you to do is make the class variables private and then make gets and sets for them on
// the previous Vin Fletcher's Arrows problem.  


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vin_s_Trouble___page_162_
{
    public class Vin_sTroubleClass
    {
        // variables
        private Fletching fletching;
        private ArrowHead arrowHead;
        private float length;


        // gets and sets
        public Fletching Fletching
        {
            get { return this.fletching; }
            set { this.fletching = value; }
        }
        public ArrowHead ArrowHead
        {
            get { return this.arrowHead; }
            set { this.arrowHead = value; }
        }
        public float Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        // methods

        public float GetCost()
        {
            float totalcost = (int)ArrowHead + (int)Fletching + (Length * .05f);
            return totalcost;
        }




        // Constructors

        public Vin_sTroubleClass(ArrowHead _arrowHead, Fletching _fletch, float _length)
        {
            this.ArrowHead = _arrowHead;
            this.Fletching = _fletch;
            this.Length = _length;
        }

    }
}
