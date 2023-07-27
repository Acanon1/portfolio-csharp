using eCommerce.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        //relaciones
        public List<Actor_Pelicula> Actors_Peliculas { get; set; }

        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //productoe
        public int ProductorId { get; set; }
        [ForeignKey("ProductorId")]
        public Productor Productor { get; set; }
    }
}
