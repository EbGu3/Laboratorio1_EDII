using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Tree.Helper;
using API_Tree.Models;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Tree_Bib;
using System.Transactions;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Tree.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Arbol Multicamino" };
        }

        /// <summary>
        /// Realizar recorrido del árbol
        /// </summary>
        /// <param name="traversal"></param>
        /// <response code="200">Recorrido mostrado correctamente</response>
        /// <response code="400">Árbol no cuenta con valores insertados o iniciado</response>
        /// <returns></returns>
        [HttpGet, Route("{traversal}")]
        public ActionResult<List<Movie>> recorrido(string traversal)
        {
            traversal = traversal.ToLower();
            List<Movie> valores_Arbol = new List<Movie>();
            Traversal buscar_Recorrido = new Traversal();
            valores_Arbol = buscar_Recorrido.Recorrido(traversal);
            if (valores_Arbol.Count == 0)
            {
                return BadRequest("No hay valores insertados.");
            }
            return Ok(valores_Arbol);
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
                Data.grado = grado;
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
            if (Data.grado > 2 && file != null)
            {
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
                    Data.Instance.full_Tree.Insertar(movie);
                    
                }
                return "Valores insertados correctamente.";
            }
            else { throw new ArgumentException($"El grado {Data.grado} del árbol es incorrecto o el archivo no cuenta con estructura Json"); }
        }
    }
}
