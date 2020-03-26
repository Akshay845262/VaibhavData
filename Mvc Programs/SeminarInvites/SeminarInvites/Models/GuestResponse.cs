using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SeminarInvites.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        [Key]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$",
            ErrorMessage ="Your email address is not in valid format." +
            "Example of correct format: abcd.pqr@xyz.xyz")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please Enter Your Phone No")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please specify whether you'll attend")]
        public Nullable<bool> WillAttend { get; set; }
    }
}