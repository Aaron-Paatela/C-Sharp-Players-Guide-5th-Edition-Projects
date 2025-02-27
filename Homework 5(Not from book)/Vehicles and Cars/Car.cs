// Written By Aaron Paatela
// 2/24/2024

// This is the Car subclass from Homework 5 problem 1.  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    public class Car : Vehicle
    {
        // variables
        private int numberOfDoors = 0;


        //Gets and Sets
        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set { numberOfDoors = value; }
        }

        // Constructors

        public Car() : this(0, "make", "model", 0)
        {

        }

        public Car(int _numberOfDoors, string _make, string _model, int _year) : base(_make, _model, _year)
        {
            this.NumberOfDoors = _numberOfDoors;
        }

        // methods
        public override string ToString() 
        {
            string message = "";
            message += $"{Year} {Make} {Model} with {NumberOfDoors} doors.";
            return message;
            
        }

    }
}
