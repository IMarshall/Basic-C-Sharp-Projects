using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATE CLASS
            Operation operation = new Operation();

            //GET USER INPUT
            Console.WriteLine("Please enter a number.");
            int UserNum = Convert.ToInt32(Console.ReadLine());

            //CALL CLASS METHOD
            operation.DivideByTwo(UserNum);

            //DISPLAY RESULT TO SCREEN
            Console.WriteLine("{0} divided by 2 is : {1}", UserNum, operation.result);

            //CALL STATIC METHOD WITH OUT PARAMETERS
            Multiply(UserNum, out int result1);

            //DISPLAY THE VALUE ASSIGNED TO THE OUT PARAMETER
            Console.WriteLine("{0} multiplied by 2 is : {1}", UserNum, result1);

            //CALL OVERLOADED STATIC METHOD WITH OUT PARAMETER PLUS OPTIONAL PARAMETER
            Multiply(UserNum, out int result2, 3);

            Console.WriteLine("{0} multiplied by 3 is : {1}", UserNum, result2);

            Console.ReadLine();
        }
        //STATIC METHOD WITH OUT PARAMETERS
        public static void Multiply(int operand1, out int result)
        {
            result = operand1 * 2;
        }

        //OVERLOAD MULTIPLY METHOD TO ALLOW DEFINING THE SECOND OPERAND ON CALL
        public static void Multiply(int operand1, out int result, int operand2 = 2)
        {
            result = operand1 * operand2;
        }

    }
}
