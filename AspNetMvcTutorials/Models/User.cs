using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTutorials.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Address
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
