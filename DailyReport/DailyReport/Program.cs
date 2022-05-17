using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial printed text
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report");

            //Ask for name
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            //Ask for course name
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            //Ask for page number and convert to int
            Console.WriteLine("What page number?");
            try
            {
                int pageNum = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Unable to convert input to integer.");
            }
            //Ask if help is needed and convert to bool
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            try
            {
                bool helpNeeded = bool.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to convert input to bool.");
            }
            //Ask for positive experiences
            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics.");
            string experience = Console.ReadLine();
            //Ask for feedback
            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            //Ask for hours and convert to int
            Console.WriteLine("How many hours did you study today?");
            try
            {
                int hours = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to convert input to integer.");
            }

            //Ending statement
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
