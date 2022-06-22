using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATE NEW STUDENT OBJECT
            Employee student = new Employee() { FirstName = "Sample", LastName = "Student" };
            
            //CALL SAYNAME SUPERCLASS METHOD
            student.SayName();

            Console.ReadLine();
        }
    }
}
