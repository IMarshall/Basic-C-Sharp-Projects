using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // CREATE ARRAYS AND LIST
            string[] stringArray = { "bumfuzzle", "fartlek", "hullaballoo", "bumbershoot", "widdershins"};

            int[] intArray = { 42, 564, 2494, 2, 12, 7};

            List<string> stringList = new List<string>() { "Jerry", "George", "Elaine", "Kramer" };

            // CREATE VARIABLE TO LOOP INPUT PROMPT UNTIL VALID INPUT IS GIVEN
            bool valid = false;

            // LOOP UNTIL VALID INPUT IS GIVEN
            while (!valid)
            {
                // ASK FOR INPUT TO SELECT INDEX OF STRING ARRAY
                Console.WriteLine("Pick a number between 1 and " + stringArray.Length + " to see a funny word.");
                // CONVERT USER INPUT TO INT, MINUS 1 TO GET PROPER INDEX, STORE RESULT IN VARIABLE
                int userSelection = Convert.ToInt32(Console.ReadLine()) - 1;
                // DISPLAY STRING AT SELECTED INDEX
                try
                {
                    Console.WriteLine("\nFunny Word: " + stringArray[userSelection]);
                    valid = true;
                }
                // CATCH USER INPUT NUMBERS OUTSIDE OF VALID RANGE
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid number.\n");
                }
            }

            // RESET VALID VARIABLE FOR LOOP OF NEXT INPUT PROMPT
            valid = false;

            // LOOP UNTIL VALID INPUT IS GIVEN
            while (!valid)
            {
                // ASK FOR INPUT TO SELECT INDEX OF INTEGER ARRAY
                Console.WriteLine("\nPick a number between 1 and " + intArray.Length + " to see your lucky number.");
                // CONVERT USER INPUT TO INT, MINUS 1 TO GET PROPER INDEX, STORE RESULT IN VARIABLE
                int userSelection = Convert.ToInt32(Console.ReadLine()) - 1;
                // DISPLAY INT AT SELECTED INDEX
                try
                {
                    Console.WriteLine("\nLucky Number: " + intArray[userSelection]);
                    valid = true;
                }
                // CATCH USER INPUT NUMBERS OUTSIDE OF VALID RANGE
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid number.");
                }
            }


            // RESET VALID VARIABLE FOR LOOP OF NEXT INPUT PROMPT
            valid = false;

            // LOOP UNTIL VALID INPUT IS GIVEN
            while (!valid)
            {
                // ASK FOR INPUT TO SELECT INDEX OF STRING LIST
                Console.WriteLine("\nPick a number between 1 and " + stringList.Count + " to see your Seinfeld character.");
                // CONVERT USER INPUT TO INT, MINUS 1 TO GET PROPER INDEX, STORE RESULT IN VARIABLE
                int userSelection = Convert.ToInt32(Console.ReadLine()) - 1;
                // DISPLAY STRING AT SELECTED INDEX
                try
                {
                    Console.WriteLine("\nSeinfeld Character: " + stringList[userSelection]);
                    valid = true;
                }
                // CATCH USER INPUT NUMBERS OUTSIDE OF VALID RANGE
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid number.");
                }
            }
            Console.Read();
        }
    }
}
