using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Enter a number:";
            int userNum;
            int result;

            Console.WriteLine(prompt);
            userNum = int.Parse(Console.ReadLine());
            result = userNum * 50;
            Console.WriteLine(userNum + " * 50 = " + result);

            Console.WriteLine(prompt);
            userNum = int.Parse(Console.ReadLine());
            result = userNum + 25;
            Console.WriteLine(userNum + " + 25 = " + result);

            Console.WriteLine(prompt);
            userNum = int.Parse(Console.ReadLine());
            float quotient = userNum / 12.5f;
            Console.WriteLine(userNum + " / 12.5 = " + quotient);

            Console.WriteLine(prompt);
            userNum = int.Parse(Console.ReadLine());
            bool greater = userNum > 50;
            Console.WriteLine("Is your number greater than 50? - " + greater);

            Console.WriteLine(prompt);
            userNum = int.Parse(Console.ReadLine());
            result = userNum % 7;
            Console.WriteLine("The remainder of " + userNum + "/7 is " + result);

            Console.ReadLine();
        }
    }
}
