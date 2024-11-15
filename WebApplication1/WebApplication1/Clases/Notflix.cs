using Microsoft.JSInterop.Implementation;

namespace WebApplication1.Clases
{
    public class Notflix
    {
        private List<Cuenta> l_cuentas;
        private Cuenta cuentaAutenticada;
        private List<Pelicula> l_peliculas;
        private List<Serie> l_series;
        private List<Juego> l_juegos;

        public List<Cuenta> L_cuentas { get => l_cuentas; set => l_cuentas = value; }
        public Cuenta CuentaAutenticada { get => cuentaAutenticada; set => cuentaAutenticada = value; }
        public List<Pelicula> L_peliculas { get => l_peliculas; set => l_peliculas = value; }
        public List<Serie> L_series { get => l_series; set => l_series = value; }
        public List<Juego> L_juegos { get => l_juegos; set => l_juegos = value; }


        public Notflix()
        {
            l_cuentas = new List<Cuenta>();
            L_peliculas = new List<Pelicula>();
        }

        public bool Login(string corrreoElectronico, string contraseña)
        {
            CuentaAutenticada = L_cuentas.FirstOrDefault(c => c.CorreoElectronico == corrreoElectronico && c.Contrasena == contraseña); //Delegado para recorrer los parametros de la listas de cuentas
            return CuentaAutenticada != null;
        }

        public List<Usuario> GetUsuarios()
        {
            if (CuentaAutenticada != null)
            {
                return CuentaAutenticada.L_usuarios;
            }
            throw new UnauthorizedAccessException("Debe iniciar sesión para ver los usuarios.");
        }

        public List<Cuenta> GetCuenta()
        {
            return l_cuentas;
        }

        public void Logout()
        {
            CuentaAutenticada = null;
        }

        public bool Regist(string corrreoElectronico, string contraseña)
        {
            if(!l_cuentas.Any(c => c.CorreoElectronico == corrreoElectronico))
            {
                Cuenta c1 = new Cuenta(corrreoElectronico, contraseña);
                l_cuentas.Add(c1);
                return true;
            }
            return false;
        }

        public List<Pelicula> GetPeliculas()
        {
            if (CuentaAutenticada != null)
            {
                return L_peliculas;
            }
            throw new UnauthorizedAccessException("Debe iniciar sesión para ver las peliculas.");
        }

        public List<Serie> GetSeries()
        {
            if (CuentaAutenticada != null)
            {
                return L_series;
            }
            throw new UnauthorizedAccessException("Debe iniciar sesión para ver las Serties.");
        }

        public List<Juego> GetJuegos()
        {
            if (CuentaAutenticada != null)
            {
                return L_juegos;
            }
            throw new UnauthorizedAccessException("Debe iniciar sesión para ver los Juegos.");
        }

        public void AddPelicula(Pelicula pelicula)
        {
            l_peliculas.Add(pelicula);
        }




    }


}
