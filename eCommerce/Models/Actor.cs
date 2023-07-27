using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public int ProfilePictureURL { get; set; }

        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
