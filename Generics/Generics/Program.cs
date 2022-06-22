using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATE NEW EMPLOYEE TONY WITH GENERIC PARAMETER STRING
            Employee<string> Tony = new Employee<string>() { firstName = "Tony", lastName = "Soprano", ID = 1 };

            //DEFINE THINGS LIST WITH GENERIC PARAMETER STRING
            Tony.things = new List<string>{ "Gabagool", "Gravy", "Guns"};

            //INSTANTIATE NEW EMPLOYEE CHRISTOPHER WITH GENERIC PARAMETER INT
            Employee<int> Christopher = new Employee<int>() { firstName = "Christopher", lastName = "Moltisanti", ID = 1 };

            //DEFINE THINGS LIST WITH GENERIC PARAMETER INT
            Christopher.things = new List<int> { 5, 12, 6};

            //FOR LOOPS TO WRITE EACH LIST OF THINGS TO THE CONSOLE
            foreach (string str in Tony.things)
            {
                Console.WriteLine(str);
            }

            foreach (int num in Christopher.things)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
