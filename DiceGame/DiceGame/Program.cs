using System;

namespace DiceGame
{
    class Program
    {
        static void Main()
        {
            int targetMin = 10;

            int targetMax = 10;

            int playerScore = 0;

            int rolls = 3;

            Dice dice = new Dice();

            Die standardDie = new Die(dice);

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            bool playing = true;

            while (playing == true)
            {
                if (name == "admin")
                {
                    Console.WriteLine("Enter your target min.");
                    targetMin = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your target max.");
                    targetMax = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("How many rolls?");
                    rolls = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\nYour target score is {0}-{1}. You have {2} rolls.\n", targetMin, targetMax, rolls);

                for (int i = 1; i <= rolls; i++)
                {
                    Console.WriteLine("Roll {0}...", i);
                    if (i > 1)
                    {
                        Console.WriteLine("Add or Subtract?");
                        string addOrSubtract = Console.ReadLine().ToLower();
                        playerScore += standardDie.Roll(1, addOrSubtract);
                    }
                    else
                    {
                        playerScore += standardDie.Roll(1);
                    }
                    
                    Console.WriteLine("Your score is {0}\n", playerScore);
                }

                if (playerScore >= targetMin && playerScore <= targetMax)
                {
                    Console.WriteLine("You won!\n");
                }
                else
                {
                    Console.WriteLine("You lost!\n");
                }

                Console.WriteLine("Play Again? (Y/N)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    playerScore = 0;
                }
                else
                {
                    playing = false;
                    Console.WriteLine("Thanks for playing.");
                }
            }
            Console.ReadLine();
        }
    }
}
