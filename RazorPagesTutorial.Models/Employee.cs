using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorPagesTutorial.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required, Range(2,20, ErrorMessage = "Name--at least two " +
            "characters but no more than 20--is required.")]
        public string Name { get; set; }
        [Required, RegularExpression
            (@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public Dept? Department { get; set; }
    }
}
