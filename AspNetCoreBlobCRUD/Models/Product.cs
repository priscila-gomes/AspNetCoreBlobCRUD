﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBlobCRUD.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public byte[] Image { get; set; }
    }
}
