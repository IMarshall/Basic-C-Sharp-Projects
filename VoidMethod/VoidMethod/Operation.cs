using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Operation
    {
        //call void method
        public void Squared(int a, int b)
        {
            int product = a * a;

            //do WriteLine methods here since these values won't be returned to the main method
            Console.WriteLine("The first number squared is " + product);

            Console.WriteLine("The second number was " + b);
        }
    }
}
