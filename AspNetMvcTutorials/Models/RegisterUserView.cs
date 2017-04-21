using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcTutorials.Models
{
    public class RegisterUserView
    {
        public int Id { set; get; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Thư điện tử")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [DisplayName("Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
        [DataType(DataType.MultilineText)]
        public string Bio { get; set; }
    }
}