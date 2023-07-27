using eCommerce.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace eCommerce.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }

        public int Price { get; set; }
        public int ImageURL { get; set; }
        public DateTime startDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategorie MovieCategorie { get; set; }
    }
}
