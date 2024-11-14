namespace WebApplication1.Clases
{
    public class Serie : Contenido
    {
        private byte temporadas;
        private int capitulos_x_temp;

        public Serie(string link, string nombre, byte temporadas, int capitulos_x_temp) : base(nombre, link)
        {
            Nombre = nombre;
            Link = link;
            this.temporadas = temporadas;
            this.capitulos_x_temp = capitulos_x_temp;
        }

        public byte Temporadas { get => temporadas; 
            set
            {
                temporadas = (value > 0) ? value : throw new Exception("La cantidad minima de temporadas es uno");
            }
        }
        public int Capitulos_x_temp { get => capitulos_x_temp;
            set
            {
                capitulos_x_temp = (value > 0) ? value : throw new Exception("La cantidad minima de capitulos por temporada es uno");
            }
        }
        
    }
}
