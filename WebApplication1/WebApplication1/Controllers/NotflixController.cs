using Castle.DynamicProxy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Aspectos;
using WebApplication1.Clases;
using WebApplication1.ClasesControllers;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class NotflixController : ControllerBase
    {
        private readonly IAuthService _authService;

        public NotflixController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")] //Envio datos del login
        public IActionResult Login([FromBody] LRequest request )
        {
            if (_authService.Login(request.CorreoELectronico, request.Contrasena)) {
                return Ok("Inicio de sesion existoso");
            }
            return Unauthorized("Credenciales incorrectas");
        }

        [HttpGet("usuarios")]
        public IActionResult GetUsuarios()
        {
            try
            {
                var usuarios = _authService.GetUsuarios();//La var toma forma de lista
                return Ok(usuarios);
            }
            catch (UnauthorizedAccessException ex) {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet("cuenta")]
        public IActionResult GetCuenta()
        {
            try
            {
                var cuenta = _authService.GetCuenta();//La var toma forma de lista
                return Ok(cuenta);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpPost("logout")]
        public IActionResult Logout() 
        {
            _authService.Logout();
            return Ok("Cierre de Sesion exitoso");
        }

        [HttpPost("register")] //Envio datos del login
        public IActionResult Register([FromBody] LRequest request)
        {
            if (_authService.Regist(request.CorreoELectronico, request.Contrasena))
            {
                return Ok("Registro de cuenta existoso");
            }
            return Conflict("La cuenta ya existe");
        }

        [HttpGet("peliculas")]
        public IActionResult GetPeliculas()
        {
            try
            {
                var l_peliculas = _authService.GetPeliculas();//La var toma forma de lista
                return Ok(l_peliculas);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet("series")]
        public IActionResult GetSeries()
        {
            try
            {
                var l_series = _authService.GetSeries();//La var toma forma de lista
                return Ok(l_series);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet("juegos")]
        public IActionResult GetJuegos()
        {
            try
            {
                var l_juegos = _authService.GetJuegos();//La var toma forma de lista
                return Ok(l_juegos);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }

}
