using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEFINE BOOL TO CONTROL WHILE LOOP
            bool success = false;

            //RUN WHILE LOOP UNTIL USER INPUT IS SUCCESSFULLY MATCHED WITH ENUM
            while (!success)
            {
                try
                {
                    //SET SUCCESS TO TRUE BEFORE ANY EXCEPTIONS CAN BE THROWN
                    success = true;
                    Console.WriteLine("Please enter the current day of the week:");

                    string userDay = Console.ReadLine();

                    //CONVERT USER INPUT STRING TO ENUM USING ENUM.PARSE METHOD
                    daysOfTheWeek day = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), userDay, true);

                    Console.WriteLine("{0} is correct!", day);
                }
                //CATCH EXCEPTIONS LIKE BAD USER INPUT
                catch (Exception e)
                {
                    //SET SUCCESS TO FALSE IF AN EXCEPTION WAS ENCOUNTERED SO THAT THE LOOP WILL RUN AGAIN
                    success = false;
                    Console.WriteLine("Please enter an actual day of the week.\n");
                }
            }
            
            Console.ReadLine();
        }

        public enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
