using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //CREATE EMPLOYEE CLASS INHERITING FROM PERSON CLASS
    public class Employee : Person, IQuittable
    {
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
    }
}
