using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Productor
    {
        [Key]
        public int Id { get; set; }
        public string FotoPerfilURL { get; set; }

        public string NombreCompleto { get; set; }
        public string Bio { get; set; }

        //relaciones
        public List<Pelicula> Peliculas { get; set; }


    }
}
