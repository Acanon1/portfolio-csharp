namespace eCommerce.Models
{
    public class Actor_Pelicula
    {
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }

        public string ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
