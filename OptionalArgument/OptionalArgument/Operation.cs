using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArgument
{
    public class Operation
    {
        public int Add(int a, int b = 1)
        {
            int sum = a + b;
            return sum;
        }
    }
}
