// Written By Aaron Paatela
// 2/24/2025

// This is the abstract base class Shape for Homework 5 Problem 3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Areas
{
    public abstract class Shape
    {
        // Variables
        private string color = "unsure";

        // Gets and Sets
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        // Constructors
        public Shape(): this("unsure")
        {

        }
        public Shape(string _color)
        {
            this.Color = _color;
        }

        // Methods
        public abstract double GetArea();

        public override string ToString()
        {
            return $"{Color} Shape";

        }
    }
}
