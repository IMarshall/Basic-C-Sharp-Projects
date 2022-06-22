using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATE NEW IQUITTABLE TONY
            IQuittable Tony = new Employee() { firstName = "Tony", lastName = "Soprano" };

            //CALL QUIT() METHOD
            Tony.Quit();

            Console.ReadLine();
        }
    }
}
