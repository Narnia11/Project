﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Model.ViewModels
{
   public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me!")]
        public bool RememberMe { get; set; }
    }
}
