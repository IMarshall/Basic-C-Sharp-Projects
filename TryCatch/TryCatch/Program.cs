using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 2, 48, 16, 27 };

            //define variable to break out of loop when there are no errors
            bool success = false;

            while (!success)
            {
                //set success to true
                success = true;

                Console.WriteLine("Enter a number to be divided by:");
                string userInput = Console.ReadLine();

                //try dividing list by user input
                try
                {
                    int userNum = Convert.ToInt32(userInput);
                    foreach (int num in numbers)
                    {
                        int result = num / userNum;
                        int remainder = num % userNum;

                        Console.WriteLine(num + " divided by " + userNum + " = " + result + " with a remainder of " + remainder + ".");
                    }
                }
                //catch errors and set success to false to allow user to try again - stay in loop
                catch (FormatException fe)
                {
                    success = false;
                    Console.WriteLine(fe.Message);
                }
                catch (DivideByZeroException dbze)
                {
                    success = false;
                    Console.WriteLine(dbze.Message);
                }
                Console.WriteLine();
                
                //add a few messages if any errors were caught, before the loop starts again
                if (!success)
                {
                    Console.WriteLine("Whew... glad we got through all those errors.");
                    Console.WriteLine();
                    Console.WriteLine("Let's try that again...");
                    Console.WriteLine();
                }
            }
            //success message for when user finally gets out of the loop
            Console.WriteLine("Congratulations! You finally made it through with no errors! I knew you could do it!");
            Console.ReadLine();
        }
    }
}
