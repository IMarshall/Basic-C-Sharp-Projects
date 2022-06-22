using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Operation
    {
        //public class methods
        public int MultiplyByTwo(int x)
        {
            x = x * 2;
            return x;
        }

        public int DivideByOne(float x)
        {
            x = x / 1;
            //convert from float to int
            return (int)x;
        }

        public int AddFive(string x)
        {
            //convert from string to int
            int intX = Convert.ToInt32(x);
            intX = intX + 5;
            return intX;
        }
    }
}
