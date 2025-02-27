// Written By Aaron Paatela
// 2/25/2025

// This is the Rectangle sublcass for Homework 5 Problem 3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Areas
{
    internal class Rectangle : Shape
    {
        // Variables
        private double rectangleWidth = 0;
        private double rectangleHeight = 0;

        // Gets and Sets
        public double RectangleWidth
        {
            get { return this.rectangleWidth; }
            set { this.rectangleWidth = value; }
        }
        public double RectangleHeight
        {
            get { return this.rectangleHeight; }
            set { this.rectangleHeight = value; }
        }

        // Constructors

        public Rectangle(): this(0, 0, "unsure")
        {

        }

        public Rectangle(double _rectangleWidth, double _rectangleHeight, string _color) : base(_color)
        {
            this.RectangleWidth = _rectangleWidth;
            this.RectangleHeight = _rectangleHeight;
        }

        public override double GetArea()
        {
            return RectangleWidth * RectangleHeight;

        }


        public override string ToString()
        {
            return $"Rectangle width: {RectangleWidth}\nRectangle Height: {RectangleHeight}\n" +
                $"Rectangle Area: {GetArea()}\nRectangle Color: {Color}";
        }
    }
}
