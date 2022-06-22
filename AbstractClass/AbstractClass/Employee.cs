using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //CREATE EMPLOYEE CLASS INHERITING FROM PERSON CLASS
    public class Employee : Person
    {
        //OVERRIDE SAYNAME() METHOD FROM PERSON CLASS
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
