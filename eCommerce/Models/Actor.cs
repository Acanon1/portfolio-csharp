using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "foto de perfil")]
        [Required(ErrorMessage ="foto de perdil es requerida")]
        public string FotoPerfilURL { get; set; }
		[Display(Name = "Nombre completo")]
		[Required(ErrorMessage = "nombre completo es requerido")]

		public string NombreCompleto { get; set; }
		[Display(Name = "Biografia")]
		[Required(ErrorMessage = "biografia es requerida")]
		public string Bio { get; set; }

        //relaciones
        public List<Actor_Pelicula> Actors_Peliculas { get; set;}
    }
}
