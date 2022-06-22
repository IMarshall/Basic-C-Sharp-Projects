using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    //CREATE ABSTRACT CLASS
    public abstract class Person
    {
        //DEFINE TWO PROPERTIES
        public string firstName { get; set; }
        public string lastName { get; set; }

        //DEFINE ABSTRACT METHOD
        public abstract void SayName();
    }
}
