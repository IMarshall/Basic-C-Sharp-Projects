using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstDb
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Tony Soprano" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
