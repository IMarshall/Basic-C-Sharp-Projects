using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class Dice
    {
        //DEFINE LIST OF ALL DICE AND ASSIGN IT A VALUE TO PREVENT ERRORS
        private List<Die> _allDice = new List<Die>();
        public List<Die> allDice { get { return _allDice; } set { _allDice = value; } }

    }
}
