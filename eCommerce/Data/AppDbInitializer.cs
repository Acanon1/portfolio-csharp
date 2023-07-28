using eCommerce.Data.Enums;
using eCommerce.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Data

{
    public class AppDbInitializer
    {
        public static void Seed(ApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Nombre = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Descripcion = "descripcion"
                        },
                        new Cinema()
                        {
                            Nombre = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Descripcion = "descripcion"
                        },
                        new Cinema()
                        {
                            Nombre = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Descripcion = "descripcion"
                        },
                        new Cinema()
                        {
                            Nombre = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Descripcion = "descripcion"
                        },
                    });
                    context.SaveChanges();
                }
                //actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            NombreCompleto = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            NombreCompleto = "Actor 1",
                            Bio = "biografia de primer actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            NombreCompleto = "Actor 2",
                            Bio = "biografia de segundo actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            NombreCompleto = "Actor 3",
                            Bio = "biografia de tercer actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            NombreCompleto = "Actor 4",
                            Bio = "biografia de cuarto actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            NombreCompleto = "Actor 5",
                            Bio = "biografia de quinto actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //productor
                if (!context.Productors.Any())
                {
                    context.Productors.AddRange(new List<Productor>()
                    {
                        new Productor()
                        {
                            NombreCompleto = "Productor 1",
                            Bio = "biografia del primer productor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Productor()
                        {
                            NombreCompleto = "Productor 2",
                            Bio = "biografia del segundo productor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-2.jpeg"

                        },
                        new Productor()
                        {
                            NombreCompleto = "Productor 3",
                            Bio = "biografia del tercer productor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-3.jpeg"

                        },
                        new Productor()
                        {
                            NombreCompleto = "Productor 4",
                            Bio = "biografia del cuarto productor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-4.jpeg"

                        },
                        new Productor()
                        {
                            NombreCompleto = "Productor 5",
                            Bio = "biografia del quinto productor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-5.jpeg"

                        },
                    });
                    context.SaveChanges();
                }
                //pelicula
                if (!context.Peliculas.Any())
                {
                    context.Peliculas.AddRange(new List<Pelicula>()
                    {
                        new Pelicula()
                        {
                            Nombre = "Life",
                            Descripcion = "Descripcion de pelicula3",
                            Precio = 39.50,
                            FotoURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            fechaInicio = DateTime.Now.AddDays(-10),
                            fechaFinal = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProductorId = 3,
                            CategoriaPelicula = CategoriaPelicula.Documentary
                        },
                        new Pelicula()
                        {
                            Nombre = "The Shawshank Redemption",
                            Descripcion = "Descripcion de pelicula1",
                            Precio = 29.50,
                            FotoURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            fechaInicio = DateTime.Now,
                            fechaFinal = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProductorId = 1,
                            CategoriaPelicula = CategoriaPelicula.Action,
                        },
                        new Pelicula()
                        {
                            Nombre = "Life",
                            Descripcion = "Descripcion de pelicula4",
                            Precio = 39.50,
                            FotoURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            fechaInicio = DateTime.Now,
                            fechaFinal = DateTime.Now.AddDays(7),
                            CinemaId = 3,
                            ProductorId = 3,
                            CategoriaPelicula = CategoriaPelicula.Drama,
                        }
                     });
                }
                //actors_peliculas
                if (!context.Actors_Peliculas.Any())
                {

                }
            }
        }
    }
}
