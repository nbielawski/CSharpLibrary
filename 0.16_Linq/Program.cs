using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new array of instructors
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Nick" };

            //Setup the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length >= 3
                                        orderby i ascending
                                        select i;

            //Loop through the array using the query

            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            IEnumerable<Employee> employees =  new List<Employee>()
            {
                new Employee {ID=1, Name="Johnboy",HireDate=new DateTime(2015,3,5)},
                new Employee {ID=13, Name="Tommy",HireDate=new DateTime(2013,6,7)},
                new Employee {ID=21, Name="Jill",HireDate=new DateTime(2011,9,4)},
                new Employee {ID=47, Name="Frank",HireDate=new DateTime(2017,8,2)},
                new Employee {ID=67, Name="Jeremy",HireDate=new DateTime(2015,3,1)}
            };

           IEnumerable<Employee> query2 = from e in employees
                                             where e.HireDate.Year==2015
                                             orderby e.HireDate ascending
                                             select e;
            foreach (Employee employee in query2)
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadLine();

        }
    }
}
