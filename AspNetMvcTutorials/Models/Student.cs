using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTutorials.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Email is invalid")]
        public string Email { get; set; }
    }
}
