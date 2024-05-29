﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public required string Url { get; set; }
        public bool IsMain { get; set; }
        public string? PublicId { get; set; }

        public int AppUserId { get; set; }
        public required AppUser AppUser { get; set; }
    }
}