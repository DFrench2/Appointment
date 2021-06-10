﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduler.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public String Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Display (Name="Remeber me")]
        public bool RemeberMe { get; set; }
    }
}
