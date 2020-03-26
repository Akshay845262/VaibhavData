using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class EmployeeMetadata
    {
        public int Id { get; set; }
        [Required]
        public string EmpName { get; set; }
        public string Place { get; set; }
        public string Skill { get; set; }
    }
}