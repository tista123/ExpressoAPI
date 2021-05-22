﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpressoAPI.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email in not valid")]
        public string Email { get; set; }
        [Required]

        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
        [Required]
        public int TotalPeople { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public string Time { get; set; }
    }
}