using WebApplication1.Clases;

namespace WebApplication1.Interfaces
{
    public class IAuthService
    {

        private readonly Notflix _notflix;

        public IAuthService()
        {
            _notflix = new Notflix();
        }

        public bool Login(string correoElectronico, string contraeña)
        {
            return _notflix.Login(correoElectronico, contraeña);
        }

        public List<Usuario> GetUsuarios()
        {
            return _notflix.GetUsuarios();
        }
        public List<Cuenta> GetCuenta()
        {
            return _notflix.GetCuenta();
        }

        public void Logout()
        {
            _notflix.Logout();
        }

        public bool IsAuthenticated()
        {
            try
            {
                _notflix.GetUsuarios();
                return true;
            }
            catch(UnauthorizedAccessException)
            {
                return false;
            }
        }

        public bool Regist(string correoElectronico, string contraeña)
        {
            return _notflix.Regist(correoElectronico, contraeña);
        }

        public List<Pelicula> GetPeliculas()
        {
            Pelicula p1 = new Pelicula("data:image/jpeg;base64,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", "lol", 120, 5);
            _notflix.AddPelicula(p1);
            return _notflix.GetPeliculas();
        }

        public List<Serie> GetSeries()
        {
            return _notflix.GetSeries();
        }

        public List<Juego> GetJuegos()
        {
            return _notflix.GetJuegos();
        }
    }

}
