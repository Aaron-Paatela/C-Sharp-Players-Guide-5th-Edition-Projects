// Written By Aaron Paatela
// 2/24/2025

// This is the Motorcycle subclass from Homework 5 Problem 1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    public class Motorcycle : Vehicle
    {
        // variables
        private bool hasSideCar = false;
        

        // gets and sets

        public bool HasSideCar
        {
            get { return this.hasSideCar; }
            set { this.hasSideCar = value; }
        }


        // constructors

        public Motorcycle(): this(false, "make", "model", 0)
        {
        }

        public Motorcycle(bool _hasSideCar, string _make, string _model, int _year) : base( _make, _model, _year)
        {
            this.HasSideCar = _hasSideCar;
        }

        // methods
        public override string ToString()
        {
            string message = "";
            message += $"{Year} {Make} {Model} (Has Sidecar: {HasSideCar}).";
            return message;
        }



    }
}
