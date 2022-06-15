using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new instance of operation class
            Operation UserOperation = new Operation();

            Console.WriteLine("Please enter two numbers, one at a time. You can leave the second one blank if you choose.");

            //assign first argument
            int a = Convert.ToInt32(Console.ReadLine());

            //try to assign second argument. this throws an error if the user chooses to leave it blank.
            try
            {
                int b = Convert.ToInt32(Console.ReadLine());

                int sum = UserOperation.Add(a, b);

                Console.WriteLine(a + " + " + b + " = " + sum);
                Console.ReadLine();
            }
            //if the user chooses not to assign a second argument call the same method with only one argument.
            catch(Exception e)
            {
                int sum = UserOperation.Add(a);

                Console.WriteLine(a + " + " + 1 + " = " + sum);
                Console.ReadLine();
            }
        }
    }
}
