using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    public class Operation
    {
        //DECLARE RESULT ATTRIBUTE
        public int result { get; set; }

        //DEFINE CLASS METHOD WHICH SETS THE VALUE OF THE RESULT ATTRIBUTE
        public void DivideByTwo(int num1)
        {
            result = num1 / 2;
        }
    }
}
