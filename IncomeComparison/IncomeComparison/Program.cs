using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //get info for person 1 and convert inputs to appropriate data types
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            float hourlyRate1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int weeklyHours1 = int.Parse(Console.ReadLine());

            //get info for person 2 and convert inputs to appropriate data types
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            float hourlyRate2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int weeklyHours2 = int.Parse(Console.ReadLine());

            //calculate annual salaries and compare them
            float annualSalary1 = hourlyRate1 * weeklyHours1 * 52;
            float annualSalary2 = hourlyRate2 * weeklyHours2 * 52;
            bool comparison = annualSalary1 > annualSalary2;

            //output results to user
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(comparison);
            Console.ReadLine();
        }
    }
}
