using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame
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
        public int Roll(int times, string addOrSubtract = "add")
        {
            var rand = new Random();
            int total = 0;

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Rolling the {0}, {1}-sided die...", color, sides);
                int score = rand.Next(1, sides+1);
                Console.WriteLine("You rolled a {0}", score);
                if(addOrSubtract == "add" || addOrSubtract == "")
                {
                    total += score;
                }
                else
                {
                    total -= score;
                }
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
