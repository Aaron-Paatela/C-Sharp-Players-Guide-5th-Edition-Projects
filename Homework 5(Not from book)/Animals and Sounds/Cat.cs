// Written By Aaron Paatela
// 2/25/2025

// This is the Cat subclass for Homework 5 Problem 4


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_and_Sounds
{
    public class Cat : Animal
    {
        // Constructors
        public Cat() : this("n/a")
        {

        }

        public Cat(string _AnimalName) : base(_AnimalName)
        {

        }

        // Methods
        public override string MakeSound()
        {
            return "Meow";
        }
        public override string ToString()
        {
            return $"Animal: {AnimalName}\nSound: {MakeSound()}";
        }
    }
}
