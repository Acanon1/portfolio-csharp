using eCommerce.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Productor: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Foto de perfil")]
        [Required(ErrorMessage ="foto perfil es requerida")]
        public string FotoPerfilURL { get; set; }
		[Display(Name = "Nombre completo")]
		[Required(ErrorMessage = "nombre completo es requerido")]

		public string NombreCompleto { get; set; }
		[Display(Name = "Biografia")]
		[Required(ErrorMessage = "biografia es requerida")]
		public string Bio { get; set; }

        //relaciones
        public List<Pelicula> Peliculas { get; set; }


    }
}
