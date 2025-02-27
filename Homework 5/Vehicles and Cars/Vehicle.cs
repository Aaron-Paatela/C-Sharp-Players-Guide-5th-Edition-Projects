// Written By Aaron Paatela
// 2/24/2025

// This is the base Vehicle class from Homework 5 problem 1.  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    public class Vehicle
    {
        // variables
        private string make = "make";
        private string model = "model";
        private int year = 0;



        // gets and sets

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        // Constructor

        public Vehicle() : this("make", "model", 0)
        {

        }
        public Vehicle(string _Make, string _Model, int _Year)
        {
            this.Make = _Make;
            this.Model = _Model;
            this.Year = _Year;
        }

        // methods
        public override string ToString()
        {
            string message = "";
            message += $"{Year} {Make} {Model}";
            return message;
        }
    }
}
