using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    //CLASS FOR EACH DIE
    public class Die
    {
        public int sides { get; set; }
        public string color { get; set; }
        public Die(Dice dice) : this(6, "White", dice)
        {

        }

        public Die(int diceSides, string diceColor, Dice dice)
        {
            sides = diceSides;
            color = diceColor;

            //ADD DIE TO DICE LIST
            dice.allDice.Add(this);
        }

        //METHOD TO ROLL A DIE THE GIVEN NUMBER OF TIMES
        public int Roll(int times)
        {
            var rand = new Random();
            int total = 0;

            for(int i=0; i<times; i++)
            {
                Console.WriteLine("Rolling the {0}, {1}-sided die...\n", color, sides);
                int score = rand.Next(1, sides);
                Console.WriteLine("You rolled a {0}\n", score);
                total += score;
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }

            return total;
        }

        //QUICK METHOD TO GET A DESCRIPTOR FOR A DIE
        public string Define()
        {
            return color + " die with " + sides + " sides.";
        }
    }
}
