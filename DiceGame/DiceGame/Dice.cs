using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame
{
    public class Dice
    {
        //DEFINE LIST OF ALL DICE AND ASSIGN IT A VALUE TO PREVENT ERRORS
        private List<Die> _allDice = new List<Die>();
        public List<Die> allDice { get { return _allDice; } set { _allDice = value; } }

    }
}
