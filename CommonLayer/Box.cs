﻿using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Box
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}