using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string FotoPerfilURL { get; set; }

        public string NombreCompleto { get; set; }
        public string Bio { get; set; }

        //relaciones
        public List<Actor_Pelicula> Actors_Peliculas { get; set;}
    }
}
