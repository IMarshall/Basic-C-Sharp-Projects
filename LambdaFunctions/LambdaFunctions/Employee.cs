using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctions
{
    //CREATE EMPLOYEE CLASS
    public class Employee
    {
        //DEFINE PROPERTIES FOR EMPLOYEES
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }

        //DEFINE CONSTRUCTOR FOR EMPLOYEES
        public Employee(string first, string last, int empID)
        {
            firstName = first;
            lastName = last;
            ID = empID;
        }
    }
}
