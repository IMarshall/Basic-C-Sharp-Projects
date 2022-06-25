using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int currentYear = DateTime.Now.Year;
                int age = 0;

                //ASK USER FOR AGE AND CATCH EXCEPTIONS LIKE STRINGS OR NEGATIVE NUMBERS
                try
                {
                    Console.WriteLine("Please enter your age.");
                    age = Convert.ToInt32(Console.ReadLine());

                    if (age <= 0)
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lies! Please enter a number, greater than zero, with no decimals.");
                    Console.Read();
                    return;
                }

                //DETERMINE IF THEY'VE HAD THEIR BIRTHDAY YET
                Console.WriteLine("Have you had your birthday this year? (Y/N)");
                string answer = Console.ReadLine().ToLower();

                int offset = 0;

                //DETERMINE OFFSET IF THEY HAVEN'T YET HAD A BIRTHDAY
                if (answer == "n")
                {
                    offset = 1;
                }
                else if (answer == "y")
                {
                    offset = 0;
                }
                else
                {
                    throw new Exception();
                }

                int birthYear = currentYear - age - offset;

                Console.WriteLine("\nYou were born in {0}", birthYear);

                Console.ReadLine();
            }
            //CATCH ALL GENERAL EXCEPTIONS THAT MAY HAVE BEEN MISSED
            catch (Exception)
            {
                Console.WriteLine("Something has gone horribly wrong.");
                Console.Read();
                return;
            }
        }
    }
}
