using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //CREATE EMPLOYEE CLASS WITH GENERIC PARAMETER
    public class Employee<T> : Person, IQuittable
    {
        public int ID { get; set; }

        //DEFINE LIST PROPERTY WITH GENERIC PARAMETER
        public List<T> things { get; set; }

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

        //OVERLOAD == OPERATOR TO MATCH EMPLOYEES BASED ON ID
        public static bool operator ==(Employee<T> emp1, Employee<T> emp2)
        {
            bool idMatch = emp1.ID == emp2.ID;
            return idMatch;
        }

        //OVERLOAD != OPERATOR TO MATCH EMPLOYEES BASED ON ID
        public static bool operator !=(Employee<T> emp1, Employee<T> emp2)
        {
            bool idMatch = emp1.ID != emp2.ID;
            return idMatch;
        }
    }
}
