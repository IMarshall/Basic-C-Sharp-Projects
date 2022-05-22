using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variable for while loop to determine if correct number has been guessed
            bool correctNum = false;

            // continue prompting user for numbers until correct number is guessed
            while (!correctNum)
            {
                Console.WriteLine("Pick a number.");
                int num = Convert.ToInt32(Console.ReadLine());

                // evaluate user input to see if they guessed correct
                switch (num)
                {
                    // if correct, set variable to true so that the while loop breaks
                    case 12:
                        Console.WriteLine("That's correct!");
                        correctNum = true;
                        break;
                    default:
                        Console.WriteLine("You guessed " + num + ". That's incorrect.");
                        break;
                }
            }

            // create variable for while loop to determine if correct color has been guessed
            bool correctColor = false;

            Console.WriteLine("Pick a color.");
            string color = Console.ReadLine();

            // use do while loop to make sure that loop executes at least once
            do
            {
                // evaluate user input to see if they guessed correct
                switch (color)
                {
                    // if correct, set variable to true so that the while loop breaks
                    case "blue":
                        Console.WriteLine("That's correct!");
                        correctColor = true;
                        break;
                    default:
                        Console.WriteLine("You guessed " + color + ". That's incorrect. Guess another color.");
                        color = Console.ReadLine();
                        break;
                }
            }
            while (!correctColor);

            // win message
            Console.WriteLine("Congratulations! You Win!");
            Console.Read();
        }
    }
}
