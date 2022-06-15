using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            Operation UserOperation = new Operation();

            //call method with two parameters
            UserOperation.Squared(12, 42);

            //call method with named parameters
            UserOperation.Squared(b: 54, a: 14);

            Console.ReadLine();
        }
    }
}
