using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    //CREATE EMPLOYEE CLASS INHERITING FROM PERSON CLASS
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        //OVERRIDE SAYNAME() METHOD FROM PERSON CLASS
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        //DEFINE METHOD INHERITED FROM IQUITTABLE INTERFACE
        public void Quit()
        {
            Console.WriteLine("{0} {1} quits.", firstName, lastName);
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            bool idMatch = emp1.ID == emp2.ID;
            return idMatch;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            bool idMatch = emp1.ID != emp2.ID;
            return idMatch;
        }
    }
}
