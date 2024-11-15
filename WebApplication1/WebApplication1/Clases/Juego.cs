namespace WebApplication1.Clases
{
    public class Juego
    {
        public enum Genero
        {
            Drama,
            Infantil,
            Comedia,
            Terror,
            Accion
        }

        private string nombre;
        private string link;
        private Genero genero_juego;



        public Juego(string nombre, string link, Genero genero_juego)
        {
            this.nombre = nombre;
            this.link = link;
            this.genero_juego = genero_juego;
        }

        public string Nombre { get => nombre;
            set
            {
                //verifico q el nombre no est vacio
                nombre = !string.IsNullOrWhiteSpace(value) ? value : throw new Exception("El nombre no puede esta vacio");
            }
        }
        public string Link { get => link; 
            set
            {
                //verifico que el link tenga por lo menos un punto
                link = (value.Contains('.') && value.Length >= 4) ? value : throw new Exception("El link debe contener un punto seguido de 2 a 3 letras, como '.com' o '.io'. y luego su id(id opcional)");
            }
        }

        public Genero Genero_juego { get => genero_juego; set => genero_juego = value; }

    }
}
