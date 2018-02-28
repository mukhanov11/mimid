using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMidterm.Models
{
    [Serializable]
    public class Customer
    {
        public int Id { set; get; }

        [Required]
        [MinLength(2, ErrorMessage = "Minimal length of Name is 2 letters")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please, enter valid Email address")]
        public string Email { get; set; }

        public Dictionary<Order, Route> OrderRoute { get; set; }
        //public List<Order> Orders { get; set; }
    }
}
