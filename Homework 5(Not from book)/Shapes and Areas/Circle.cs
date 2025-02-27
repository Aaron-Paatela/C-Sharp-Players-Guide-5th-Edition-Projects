// Written By Aaron Paatela
// 2/25/2025

//  This is the Circle subclass from Homework 5 Problem 3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Areas
{
    internal class Circle : Shape
    {
        // Variables
        private double circleRadius = 0;

        // Gets and Sets
        public double CircleRadius
        {
            get { return this.circleRadius; }
            set { this.circleRadius = value; }
        }


        // Constructors

        public Circle() : this(0, "unsure")
        {

        }

        public Circle(double _circleRadius, string _color) : base(_color)
        {
            this.CircleRadius = _circleRadius;
        }


        // methods

        public override double GetArea()
        {
            return Math.PI * Math.Pow(CircleRadius, 2);
        }


        public override string ToString()
        {
            return $"Radius: {CircleRadius}\nArea: {GetArea()}\nColor: {Color}";
        }

    }
}
