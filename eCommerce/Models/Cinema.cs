using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //relaciones
        public List<Pelicula> Peliculas { get; set; }
    }
}
