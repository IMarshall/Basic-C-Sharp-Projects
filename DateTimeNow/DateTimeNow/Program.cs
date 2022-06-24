using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeNow
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEFINE DATETIME WITH CURRENT DATE AND TIME
            DateTime now = DateTime.Now;
            Console.WriteLine("The current date and time is {0}\n", now);

            Console.WriteLine("Please enter a number.");
            //ASSIGN USER INPUT TO DOUBLE
            double x = Convert.ToInt32(Console.ReadLine());
            //DEFINE ANOTHER DATETIME THAT CALCULATES NOW+X HOURS USING THE .AddHours() METHOD
            DateTime later = now.AddHours(x);

            //PRINT RESULTS TO CONSOLE
            Console.WriteLine("\n{0} hours from now, the date and time will be {1}", x, later);

            Console.Read();
        }
    }
}
