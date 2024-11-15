namespace WebApplication1.Clases
{
    public class Pelicula : Contenido
    {
        private Guid id;
        private int duracion_min;
        private byte calificacion;

        //Costructor
        public Pelicula(string link, string nombre, int duracion_min, byte calificacion) : base(nombre, link)
        {
            Id = Guid.NewGuid(); // Genera un ID único para cada instancia
            Nombre = nombre;
            Link = link;
            this.Duracion_min = duracion_min;
            this.Calificacion = calificacion;
        }

        //Accesores
        public int Duracion_min { get => duracion_min;
            set 
            {
                duracion_min = (value > 0 && value <= 300) ? value : throw new Exception("Revise la duracion");
            }
        }

        public byte Calificacion { get => calificacion; 
            set
            {
                calificacion = (value >= 1 && value <= 5) ? value : throw new Exception("La calificacion debe estar entre 1 y 5");
            }
        }
        public Guid Id { get => id; private set => id = value; }
    }
}
