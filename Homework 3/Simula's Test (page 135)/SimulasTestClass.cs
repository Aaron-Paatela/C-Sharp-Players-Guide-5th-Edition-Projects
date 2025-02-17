// Written By Aaron Paatela
// 2/14/2025
// This is the separate class for the Homework 3 Simula's Test exercise
// in C# Player's Guide 5th edition on page 135


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simula_s_Test__page_135_
{
    public class SimulasTestClass
    {

        // variables
        public ChestState currentChestState = ChestState.locked;




        // methods
        public string OpenCloseLockEnumLoop(string aString)
        {

            string message = "";
            if (currentChestState == ChestState.locked && aString == "unlock")
            {
                currentChestState = ChestState.closed;
                message = "The chest has been unlocked";
            }
            else if (currentChestState == ChestState.closed && aString == "open")
            {
                currentChestState = ChestState.open;
                message = "The chest has been opened.";
            }
            else if (currentChestState == ChestState.open && aString == "close")
            {
                currentChestState = ChestState.closed;
                message = "The chest has been closed.";
            }
            else if (currentChestState == ChestState.closed && aString == "lock")
            {
                currentChestState = ChestState.locked;
                message = "The chest has been locked.";
            }
            else
            {
                message = "That is not currently a valid command.";
            }
            return message;


        }




        //Constructors

        public SimulasTestClass(ChestState aChestState)
        {
            this.currentChestState = aChestState;
        }

        // other types
        public enum ChestState
        {
            open,
            closed,
            locked,
        }
    }

}
