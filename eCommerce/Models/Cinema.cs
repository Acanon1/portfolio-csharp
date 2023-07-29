using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Cinema logo is required")]
        public string Logo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //relaciones
        public List<Pelicula> Peliculas { get; set; }
    }
}
