using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATE NUMBER AND ASSIGN THE AMOUNT
            Number number = new Number() { Amount = 12 };

            //PRINT AMOUNT TO CONSOLE
            Console.WriteLine(number.Amount);

            Console.Read();
        }
    }
}
