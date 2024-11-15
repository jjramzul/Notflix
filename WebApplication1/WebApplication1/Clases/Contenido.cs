namespace WebApplication1.Clases

{
     public abstract class Contenido
    {
        protected string nombre;
        protected string link;

        // Atributo estático para contar las instancias de esta clase o sus derivados
        public static int TotalContenido { get; private set; } = 0; //Con el private set me aseguro que la propiedad solo se modifica desde dentro de la clase

        public Contenido(string nombre, string link)
        {
            this.nombre = nombre;
            this.link = link;
            TotalContenido++;  // Incrementa cada vez que se crea una instancia
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
                link = (value.Length >= 4) ? value : throw new Exception("El link debe contener un punto seguido de 2 a 3 letras, como '.com' o '.io'. y luego su id(id opcional)");
            }
        }

    }
}
