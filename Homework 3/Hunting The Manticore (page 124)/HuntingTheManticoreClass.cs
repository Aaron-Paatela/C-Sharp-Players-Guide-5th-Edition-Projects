// Written By Aaron Paatela
// 2/12/2025
// This is the separate class for the Hunting The Manticore exercise
// in the C# Players Guide 5th Edition on page 124


using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunting_The_Manticore__page_124_
{
    public class HuntingTheManticoreClass
    {
        // variables

        private int cityHealth = 0;
        private int manticoreHealth = 0;
        private int currentRound = 0;
        private int manticoreLocation = int.MaxValue;

        // gets and sets

        public int CityHealth
        {
            get { return this.cityHealth; }
            set { this.cityHealth = value; }
        }
        public int ManticoreHealth
        {
            get { return this.manticoreHealth; }
            set { this.manticoreHealth = value; }
        }
        public int CurrentRound
        {
            get { return this.currentRound; }
            set { this.currentRound = value; }
        }
        public int ManticoreLocation
        {
            get { return this.manticoreLocation; }
            set { this.manticoreLocation = value; }
        }




        // Methods

        public string CannonShot(int anInt)
        {
            string message = string.Empty;
            if (anInt == ManticoreLocation)
            {
                if (CurrentRound % 5 == 0 && CurrentRound % 3 == 0)
                {
                    ManticoreHealth -= 10;
                }

                else if (CurrentRound % 3 == 0 || CurrentRound % 5 == 0)
                {
                    ManticoreHealth -= 3; 
                }  
                else
                {
                    ManticoreHealth -= 1;
                }
                message += "That round was a DIRECT HIT!";
                
            }
            else if ( anInt < ManticoreLocation )
            {
                message += "That round FELL SHORT of the target.";
            }
            else
            {
                message += "That round OVERSHOT the target.";
            }
            return message;

        }






        // constructors

        public HuntingTheManticoreClass():this(15, 10, 1, int.MaxValue)
        {

        }

        public HuntingTheManticoreClass(int _CityHealth, int _ManticoreHealth, int _CurrentRound, int _ManticoreLocation)
        {
            this.CityHealth = _CityHealth;
            this.ManticoreHealth = _ManticoreHealth;
            this.CurrentRound = _CurrentRound;
            this.ManticoreLocation = _ManticoreLocation;
        }
    }
}
