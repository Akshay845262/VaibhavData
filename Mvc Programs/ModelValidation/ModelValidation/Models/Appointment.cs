using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelValidation.Infrastructure;
using System.Web.Mvc;

namespace ModelValidation.Models
{
    public class Appointment
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        [StringLength(10,MinimumLength =3)]
        public string ClientName { get; set; }
        [DataType(DataType.Date)]
        //[Required(ErrorMessage ="Please enter a date (validated from model class)")]
        //[FutureDate(ErrorMessage = "Please enter a date (validated from model class)")]
        [Remote("ValidateDate","Home")]
        public DateTime Date { get; set; }
        //[Range(typeof(bool),"true","true",ErrorMessage ="You must accept the terms")]
        [MustBeTrue(ErrorMessage="You must accept the terms")]
        public bool TermsAccepted { get; set; }
    }
}