﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using fix.Models;

namespace fix.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public DateTime? DateAdded { get; set; }

        public DateTime? ReleaseDate { get; set; }
        [Range(1,20)]
        public byte NumberInStock { get; set; }
    }
}