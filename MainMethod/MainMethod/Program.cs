using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the Operation class
            Operation o = new Operation();

            //call class methods and assign the returned values to variables
            int num1 = o.MultiplyByTwo(5);
            Console.WriteLine(num1);

            int num2 = o.DivideByOne(3.14F);
            Console.WriteLine(num2);

            int num3 = o.AddFive("64");
            Console.WriteLine(num3);

            Console.ReadLine();
        }
    }
}
