using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    //CREATE PERSON CLASS
    public class Person
    {
        //DEFINE FIRST AND LAST NAME PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //DEFINE VOID METHOD TO PRINT THE PERSON'S NAME TO THE CONSOLE
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
