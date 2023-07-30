using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Productor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Foto de perfil")]
        public string FotoPerfilURL { get; set; }
		[Display(Name = "Nombre completo")]

		public string NombreCompleto { get; set; }
		[Display(Name = "Biografia")]
		public string Bio { get; set; }

        //relaciones
        public List<Pelicula> Peliculas { get; set; }


    }
}
