using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
    
        public string Logo { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        //relaciones
        public List<Pelicula> Peliculas { get; set; }
    }
}
