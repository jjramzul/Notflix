using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Clases;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JuegoController : ControllerBase
    {

        //GET: api/Juego
        [HttpGet(Name = "lol")]
        public IActionResult Get()
        {
            Console.WriteLine("obtengo");
            return Ok();
        }

        //POST: api/Juego
        [HttpPost]
        public IActionResult Post()
        {
            Console.WriteLine("envio");
            return Ok();
        }

        //POST: api/Juego
        [HttpPut]
        public IActionResult Put()
        {
            Console.WriteLine("remplazo");
            return Ok();
        }

        //POST: api/Juego
        [HttpDelete]
        public IActionResult Delete()
        {
            Console.WriteLine("eliminar");
            return Ok();
        }
    }
}
