using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Tree.Helper;

namespace API_Tree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class moviesController : ControllerBase
    {
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
        public ActionResult InsertarVarios()
        {
            throw new Exception();
            //return Ok("Valores ingresados correctamente");
        }
    }
}
