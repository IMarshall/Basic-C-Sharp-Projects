using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for info and store it in the appropriate variables
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? answer \"true\" or \"false\"");
            bool dui = bool.Parse(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = int.Parse(Console.ReadLine());
            Console.WriteLine("Qualified?");

            // Use && operator to determine if the applicant is qualified
            Console.WriteLine(age > 15 && dui == false && tickets <= 3);

            Console.ReadLine();
        }
    }
}
