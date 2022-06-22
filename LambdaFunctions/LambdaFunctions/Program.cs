using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE LIST OF EMPLOYEES AND ADD 10 EMPLOYEES
            List<Employee> employees = new List<Employee>();

            Employee emp1 = new Employee("Tony", "Soprano", 1);
            employees.Add(emp1);

            Employee emp2 = new Employee("Christopher", "Moltisanti", 2);
            employees.Add(emp2);

            Employee emp3 = new Employee("Joe", "Schmuckatelli", 3);
            employees.Add(emp3);

            Employee emp4 = new Employee("Walter", "White", 4);
            employees.Add(emp4);

            Employee emp5 = new Employee("Jesse", "Pinkman", 5);
            employees.Add(emp5);

            Employee emp6 = new Employee("Joe", "Schmoe", 6);
            employees.Add(emp6);

            Employee emp7 = new Employee("Homer", "Simpson", 7);
            employees.Add(emp7);

            Employee emp8 = new Employee("Moe", "Sizlack", 8);
            employees.Add(emp8);

            Employee emp9 = new Employee("Joe", "Mama", 9);
            employees.Add(emp9);

            Employee emp10 = new Employee("Cosmo", "Kramer", 10);
            employees.Add(emp10);

            //CREATE LIST OF JOES AND USE FOREACH LOOP TO FIND THEM
            List<Employee> joes = new List<Employee>();

            foreach(Employee employee in employees)
            {
                if(employee.firstName == "Joe")
                {
                    joes.Add(employee);
                    Console.WriteLine("{0} {1}", employee.firstName, employee.lastName);
                }
            }

            //CREATE LIST OF JOES AND USE LAMBDA FUNCTION TO FIND THEM
            List<Employee> joesLambda = employees.Where(e => e.firstName == "Joe").ToList();

            foreach (Employee employee in joesLambda)
            {
                Console.WriteLine("{0} {1}", employee.firstName, employee.lastName);
            }

            //CREATE LIST OF EMPLOYEES WITH ID GREATER THAN 5 AND USE LAMBDA FUNCTION TO FIND THEM
            List<Employee> greaterThan5 = employees.Where(e => e.ID > 5).ToList();

            foreach (Employee employee in greaterThan5)
            {
                Console.WriteLine("{0} {1}", employee.firstName, employee.lastName);
            }

            Console.Read();
        }
    }
}
