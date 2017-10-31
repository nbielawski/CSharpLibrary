using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student jayStudent= new Student();
            //jayStudent.FirstName = "Jay";
            //jayStudent.LastName = "Jackson";
            //jayStudent.Age = 5;
            //jayStudent.Grade = 1;

            Student jayStudent = new Student("Jay", "Jackson", 5, 1);

            Student nickStudent = new Student("Nicholas", "Bielawski", 27);



        }
    }
}
