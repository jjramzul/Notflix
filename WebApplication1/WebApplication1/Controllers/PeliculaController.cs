using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeliculaController : ControllerBase
    {
        //GET: api/Pelicula
        [HttpGet(Name = "lol2")]
        public IActionResult Get()
        {
            Console.WriteLine("obtengo");
            return Ok("recibiendo informacion");
        }

    }
}
