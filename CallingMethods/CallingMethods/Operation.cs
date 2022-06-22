using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Operation
    {
        //define three methods to operate on the user's input
        public static int MultiplyByTwo(int x)
        {
            x = x * 2;
            return x;
        }

        public static int Squared(int x)
        {
            x = x * x;
            return x;
        }

        public static float DivideByTwo(float x)
        {
            x = (float)x/2;
            return x;
        }
    }
}
