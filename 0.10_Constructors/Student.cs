using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Student
    {

        public Student(string lastName, int grade)
        {
            this.LastName = lastName;
            this.Grade = grade;
        }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public Student (string firstName)
        {
            this.FirstName = firstName;
        }
        
        //Constructor

            public  Student(int Grade, string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = Grade;
        }

        public Student(string firstName, string lastName, int age, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Grade = grade;
        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
            
    }
}
