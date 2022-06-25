using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE TWO CONSTANT VARIABLES TO DEFINE MIN AND MAX SCORES
            const int targetScoreMin = 20;
            const int targetScoreMax = 22;

            //CREATE VARIABLE USING VAR KEYWORD
            var playerScore = 0;

            Dice dice = new Dice();

            Die Standard = new Die(dice);

            Die Blue20 = new Die(20, "Blue", dice);

            Die Rainbow11 = new Die(11, "Rainbow", dice);

            Console.WriteLine("This game is called 2022...\n");
            Console.WriteLine("(Press enter to continue...)");
            Console.ReadLine();
            Console.WriteLine("The goal of the game is to score between 20 and 22...");
            Console.ReadLine();
            Console.WriteLine("You have three dice...");
            Console.ReadLine();
            Console.WriteLine("One standard, 6-sided die...");
            Console.ReadLine();
            Console.WriteLine("One blue 20-sided die...");
            Console.ReadLine();
            Console.WriteLine("And one rainbow, 11-sided die.");
            Console.ReadLine();
            Console.WriteLine("You may roll each die as many times as you want, but you MUST roll each die at least once.");
            Console.ReadLine();
            Console.WriteLine("Ready to play? (Y/N)");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine();

            if(answer == "y")
            {
                bool playing = true;
                //GAME LOOP
                while (playing)
                {
                    printScore(playerScore);

                    //PLAYER MAKES CHOICE OF HOW MANY TIMES TO ROLL EACH DIE
                    foreach (Die die in dice.allDice)
                    {
                        Console.WriteLine("How many times would you like to roll the {0}", die.Define());
                        int times = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        playerScore += die.Roll(times);
                        Console.WriteLine("Your score is {0}\n", playerScore);
                    }
                    Console.WriteLine("Your final score is {0}", playerScore);

                    //DETERMINE IF PLAYERSCORE FITS TARGETSCORE RANGE
                    if (playerScore >= targetScoreMin && playerScore <= targetScoreMax)
                    {
                        Console.WriteLine("Congratulations! You beat 2022!\n");
                    }
                    else if (playerScore < targetScoreMin)
                    {
                        Console.WriteLine("You didn't quite do enough in 2022. You need to take more risks!\n");
                    }
                    else
                    {
                        Console.WriteLine("You overdid it in 2022. Maybe be a little more careful with your decisions in the future!\n");
                    }
                    Console.WriteLine("Would you like to play again? (Y/N)");
                    string response = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    //CONTINUE TO PLAY GAME OR BREAK LOOP
                    if (response == "y")
                    {
                        playerScore = 0;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        playing = false;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Guess 2022 is just too much for you.");
            }


            Console.Read();
        }

        //METHOD TO PRINT SCORE A LITTLE FASTER
        static void printScore(int score)
        {
            Console.WriteLine("Your total score is {0}\n", score);
        }
    }
}
