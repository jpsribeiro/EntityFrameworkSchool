using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class School
    {
        public School() { }

        public School(int id, string name)
        {
            Id = id;
            Name = name;

            Active = true;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public List<Student> Students {get; set;}

        public ContactInfromation ContactInfromation { get; set; }

        public void AddStudent(string name) 
        {
            
        }

        public void AddContactInformation(string fullAdress) 
        {
            
        }
    }
}
