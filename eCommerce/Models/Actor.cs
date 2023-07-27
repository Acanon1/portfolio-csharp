﻿using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public int FotoPerfilURL { get; set; }

        public string NombreCompleto { get; set; }
        public string Bio { get; set; }
    }
}
