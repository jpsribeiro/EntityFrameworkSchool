using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class Student
    {
        protected Student() { }

        public Student(string name) 
        {
            FullName = name;
        }

        public int Id { get; set; }
        public string FullName { get; set; }

        public School School { get; set; }

        public int SchoolId { get; set; }

    }
}
