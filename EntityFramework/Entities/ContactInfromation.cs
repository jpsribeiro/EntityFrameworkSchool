using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class ContactInfromation
    {
        protected ContactInfromation() { }

        public ContactInfromation(string fulladress, string phonenumber) 
        {
            FullAdress = fulladress;
            PhoneNumber = phonenumber;
        }

        public int Id { get; set; }
        public string FullAdress { get; set; }
        public string PhoneNumber { get; set; }

        public int SchoolId { get; set; }
    }
}
