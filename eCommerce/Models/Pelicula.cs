using eCommerce.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace eCommerce.Models
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }
        public int Nombre { get; set; }
        public int Descripcion { get; set; }

        public int Precio { get; set; }
        public int ImageURL { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public CategoriaPelicula CategoriaPelicula { get; set; }
    }
}
