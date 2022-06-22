using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATE NEW EMPLOYEE TONY
            Employee Tony = new Employee() { firstName = "Tony", lastName = "Soprano" };

            //CALL SAYNAME() METHOD
            Tony.SayName();

            Console.ReadLine();
        }
    }
}
