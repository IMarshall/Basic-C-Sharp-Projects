using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATE NEW EMPLOYEE TONY
            Employee Tony = new Employee() { firstName = "Tony", lastName = "Soprano", ID = 1 };

            Employee Christopher = new Employee() { firstName = "Christopher", lastName = "Moltisanti", ID = 1 };

            Console.WriteLine(Tony == Christopher);

            Console.ReadLine();
        }
    }
}
