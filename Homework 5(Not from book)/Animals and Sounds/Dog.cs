// Written By Aaron Paatela
// 2/26/2025

// This is the Dog subclass for Homework 5 Problem 4


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_and_Sounds
{
    public class Dog : Animal
    {
        //constructors

        public Dog()
        {

        }

        public Dog(string _AnimalName) : base(_AnimalName)
        {

        }

        // Methods
        public override string MakeSound()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return $"Animal: {AnimalName}\nSounds: {MakeSound()}";
        }

    }
}
