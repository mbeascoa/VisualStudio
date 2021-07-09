using System;
namespace WebApiPeliculasGenericas.Models
{
    public class Pelicula
    {
        public int idPelicula { get; set; }
        public String nombre { get; set; }
        public int precio { get; set; }
        public int anno { get; set; }
        public String genero { get; set; }
        public String argumento { get; set; }
        public String director { get; set; }
        public String actores { get; set; }
        public String imagen { get; set; }


        public Pelicula()
        {
        }

    }
}



