﻿using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dtos
{
    public class LoginDto
    {
        [Required]
        public required string Username { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
