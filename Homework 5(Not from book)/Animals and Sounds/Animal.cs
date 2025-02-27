// Written By Aaron Paatela
// 2/26/2025

// This is the Animal base class for Homework 5 Problem 4.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_and_Sounds
{
    public class Animal
    {
        // Variables
        private string animalName = "n/a";


        //gets and sets
        public string AnimalName
        {
            get { return this.animalName; }
            set { this.animalName = value; }
        }

        // Constructors

        public Animal() : this("n/a")
        {
            
        }
        public Animal(string _AnimalName)
        {
            this.AnimalName = _AnimalName;
        }

        // methods

        public virtual string MakeSound()
        {
            return "Some generic animal sound.";
        }

        public override string ToString()
        {
            return $"Animal: {AnimalName}\nSound: {MakeSound()}";
        }

    }
}
