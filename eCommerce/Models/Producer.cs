using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public int ProfilePictureURL { get; set; }

        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
