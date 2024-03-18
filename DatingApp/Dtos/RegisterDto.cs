﻿using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dtos
{
    public class RegisterDto
    {
        [Required]
        public required string UserName { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
