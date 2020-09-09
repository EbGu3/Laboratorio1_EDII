using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Tree.Helper;
using API_Tree.Models;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using Tree_Bib;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Tree.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Realizar recorrido del árbol
        /// </summary>
        /// <param name="traversal"></param>
        /// <response code="200">Recorrido mostrado correctamente</response>
        /// <response code="400">Árbol no cuenta con valores insertados o iniciado</response>
        /// <returns></returns>

        [HttpGet, Route("{traversal}")]
        public ActionResult recorrido(string traversal)
        {
            //Recorrer árbol según solicitud
            return Ok("Recorrido");
        }

        /// <summary>
        /// Establecer grado del árbol
        /// </summary>
        /// <param name="grado"></param>
        /// <response code="200">Grado establecido en el árbol</response>
        /// <response code="400">Grado no válido</response>
        /// <returns></returns>
        [HttpPost]
        public IActionResult RequestJson([FromForm] int grado)
        {
            if (grado > 2)
            {
                Data.Instance.grado = grado;
                return Ok("Grado del árbol guardado correctamente.");
            }
            else
            {
                return BadRequest("El grado debe de ser mayor a 2.");
            }
        }

        /// <summary>
        /// Insertar valores varios en formato json
        /// </summary>
        /// <response code="200">Valores ingresados correctamente</response>
        /// <response code="400">El formato json no se encuentra correcto o falta un dato</response>
        /// <returns></returns>
        [HttpPost, Route("populate")]

        public async Task<string> InsertarVarios([FromForm] IFormFile file)
        {
            if (Data.Instance.grado > 2)
            {
                List<Movie> list = new List<Movie>();
                ArbolM<Movie> arbolM = new ArbolM<Movie>(Data.Instance.grado);

                using var ContentMemory = new MemoryStream();
                await file.CopyToAsync(ContentMemory);
                var content = Encoding.ASCII.GetString(ContentMemory.ToArray());

                var nuevo = JsonConvert.DeserializeObject<List<Movie>>(content);

                foreach (var item in nuevo)
                {
                    var movie = new Movie
                    {
                        director = item.director,
                        imdbRating = item.imdbRating,
                        genre = item.genre,
                        releaseDate = item.releaseDate,
                        rottenTomatoesRating = item.rottenTomatoesRating,
                        title = item.title
                    };

                    arbolM.Insertar(movie);
                }

                return "OK";
            }
            else { throw new ArgumentException($"El grado {Data.Instance.grado} del árbol es incorrecto"); }
 
        }

    }
}
