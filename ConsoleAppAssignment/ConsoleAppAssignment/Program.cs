using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blurbs = { "Sally", "Fish", "Yellow", "Plum" };

            int inputCounter = 1;

            // While loop with <= condition
            while (inputCounter <= 5)
            {
                Console.WriteLine("Type something and press enter.");
                string input = Console.ReadLine();

                //add user input to each string and display them
                for (int i = 0; i < blurbs.Length; i++)
                {
                    blurbs[i] = blurbs[i] + " " + input;
                }

                foreach (string blurb in blurbs)
                {
                    Console.WriteLine(blurb);
                }

                inputCounter++;
            }

            Console.WriteLine();

            List<string> drivers = new List<string>() { "Carlos Sainz", "Sergio Perez", "Fernando Alonso", "Pierre Gasly" };

            Console.WriteLine("Type the name of an F1 driver to search our list.");
            string userInput = Console.ReadLine();

            bool driverFound = false;

            //search list of strings for user input
            foreach (string driver in drivers)
            {
                if (driver.Contains(userInput)) {
                    Console.WriteLine(userInput + " was found at index " + drivers.IndexOf(driver));
                    driverFound = true;
                    //end loop if string is found
                    break;
                }
            }
            //print not found message if string isn't found
            if (!driverFound)
            {
                Console.WriteLine("No driver found with that name.");
            }

            Console.WriteLine();

            // search list for duplicates
            List<string> colors = new List<string>() { "orange", "blue", "red", "yellow", "orange", "purple", "green" };

            Console.WriteLine("Type the name of a color to search our list.");
            string userColor = Console.ReadLine();

            bool colorFound = false;

            //search list of strings for user input
            foreach (string color in colors)
            {
                if (color.Contains(userColor))
                {
                    Console.WriteLine(userColor + " was found at index " + colors.IndexOf(color));
                    colorFound = true;
                }
            }
            //print not found message if string isn't found
            if (!colorFound)
            {
                Console.WriteLine("Couldn't find that color in our list.");
            }

            Console.WriteLine();

            // part 6
            List<string> uniqueColors = new List<string>();

            foreach(string color in colors)
            {
                // display the color from the original list
                Console.WriteLine();

                //evaluate if that color has already appeared
                bool unique = true;

                //check uniqueColors list for each color
                foreach(string uniqueColor in uniqueColors)
                {
                    //if color is already in uniqueColors list, display a message and set unique variable to false
                    if (uniqueColor == color)
                    {
                        Console.WriteLine(color + " has already appeared in the list.");
                        unique = false;
                        break;
                    }
                }

                //if unique variable is still true (color didn't appear in uniqueColors list) add color to the uniqueColors list and display a message
                if (unique == true)
                {
                    Console.WriteLine("This is the first time " + color + " has appeared in the list.");
                    uniqueColors.Add(color);
                }
            }
            Console.ReadLine();
        }
    }
}
