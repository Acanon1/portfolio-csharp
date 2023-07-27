﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public int Logo { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
    }
}