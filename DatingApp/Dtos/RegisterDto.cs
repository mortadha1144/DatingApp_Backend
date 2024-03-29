﻿using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dtos
{
    public class RegisterDto
    {
        [Required]
        public required string UserName { get; set; }
        [Required]
        [StringLength(8,MinimumLength = 4)]
        public required string Password { get; set; }
    }
}
