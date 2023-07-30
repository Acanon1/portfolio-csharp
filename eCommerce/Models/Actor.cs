using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "foto de perfil")]
        public string FotoPerfilURL { get; set; }
		[Display(Name = "Nombre completo")]

		public string NombreCompleto { get; set; }
		[Display(Name = "Biografia")]
		public string Bio { get; set; }

        //relaciones
        public List<Actor_Pelicula> Actors_Peliculas { get; set;}
    }
}
