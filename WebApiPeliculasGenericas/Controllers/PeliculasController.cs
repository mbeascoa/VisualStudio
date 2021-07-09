using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiPeliculasGenericas.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPeliculasGenericas.Controllers
{
    [Route("api/[controller]")]
    public class PeliculasController : Controller
    {

        List<Pelicula> listapeliculas = new List<Pelicula>();

        public PeliculasController()
        {




            // creamos 4 peliculas en Csharp muy parecido a java, nos permir hacerlo parecido a java
            // p.idPersona = 1
            // p.nombre = "Mikel"
            Pelicula p = new Pelicula {
                idPelicula = 1,
                nombre = "Pedro",
                precio = 4000, anno = 2021,
                genero = "Aventuras",
                argumento = "Esta pelicula es muy de accion",
                director = "Mikelon",
                actores = "Polla Record",
                imagen = "destino_aventuras.jpg" };
            this.listapeliculas.Add(p);

            p = new Pelicula {
                idPelicula = 2,
                nombre = "Dos corren por tres malas calles",
                precio = 7000,
                anno = 2020,
                genero = "Terror",
                argumento = "Esta pelicula es muy de terror",
                director = "Mikel Cain", actores = "Malo Record",
                imagen = "destino_terror.jpg" };
            this.listapeliculas.Add(p);

            p = new Pelicula {
                idPelicula = 3,
                nombre = "Dos corren por tres romanticas calles",
                precio = 1000, anno = 2021,
                genero = "Romántica",
                argumento = "Esta pelicula es muy romantica",
                director = "Mikel Amoroso",
                actores = "Romantico Record",
                imagen = "destino_romantico.jpg" };
            this.listapeliculas.Add(p);

            p = new Pelicula { idPelicula = 4,
                nombre = "Dos corren por tres comicas calles",
                precio = 4000,
                anno = 2021,
                genero = "Aventuras",
                argumento = "Esta pelicula es muy comica",
                director = "Mikel Comico",
                actores = "Comico Record", imagen = "destino_comico.jpg" };
            this.listapeliculas.Add(p);
        }



        // GET api/<controller>
        // GET api/Peliculas
        //https://localhost:5001/api/Peliculas

        [HttpGet]
        public List<Pelicula> GetPeliculas()
        {
            return this.listapeliculas;
        }

        // GET api/<controller>/1
        //GET api/Peliculas/1
        //https://localhost:5001/api/ApiPeliculas/1   así se le interroga para que funcione perfectamente la variable se encierra entre corchetes y estos dentro de comillas
        // parentesis comillas y corchete
        [HttpGet("{identificador}")]

        public Pelicula GetPelicula(int identificador)
        {
            Pelicula p = this.listapeliculas.Find(z => z.idPelicula == identificador);
            return p;
        }
        // GET api/<controller>/pornombre/Pedro
        //GET api/Peliculas/pornombre/Pedro
        //https://localhost:5001/api/Peliculas/PorNombre/Pedro   así se le interroga para que funcione perfectamente la variable se encierra entre corchetes y estos dentro de comillas
        // parentesis comillas y corchete
        [HttpGet("[action]/{name}")]

        public Pelicula PorNombre (String name)
        {
            Pelicula p = this.listapeliculas.Find(z => z.nombre == name);
            return p;
        }

        // GET api/<controller>/poridynombre
        //GET api/Peliculas/1
        //https://localhost:5001/api/Peliculas/PorNombre/Pedro/1  así se le interroga para que funcione perfectamente la variable se encierra entre corchetes y estos dentro de comillas
        // parentesis comillas y corchete
        [HttpGet("[action]/{name}/{id}")]

        public Pelicula PorIdNombre(String name, int id)
        {
            Pelicula p = this.listapeliculas.Find(z => z.nombre == name && z.idPelicula==1);
            return p;
        }
    }
}