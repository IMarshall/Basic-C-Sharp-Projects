using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CallingMethods.Operation;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variable to govern while loop
            bool correctInput = false;

            while (!correctInput)
            {
                //using a try catch to catch any errors in user input
                try
                {
                    //switch bool so that loop ends if no errors are encountered
                    correctInput = true;

                    //get user input and convert to integer
                    Console.WriteLine("Please enter a whole number.");
                    string userInput = Console.ReadLine();
                    int userNum = Convert.ToInt32(userInput);

                    //call all three methods and assign their returned values to variables
                    int m = MultiplyByTwo(userNum);
                    float d = DivideByTwo(userNum);
                    int s = Squared(userNum);

                    //display results of each method
                    Console.WriteLine("\n" + userNum + " divided by 2 is " + d + ".\n");
                    Console.WriteLine(userNum + " multiplied by two is " + m + ".\n");
                    Console.WriteLine(userNum + " squared is " + s);
                }
                //catch user input that can't be converted to integer
                catch (FormatException fe)
                {
                    //display error message
                    Console.WriteLine("\n"+fe.Message);
                    Console.WriteLine("Try again.\n");

                    //switch bool back to false to restart loop
                    correctInput = false;
                }
            }
            Console.ReadLine();
        }
    }
}
