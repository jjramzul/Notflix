using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace WebApplication1.Clases
{
    public class Usuario
    {
        private Guid id;
        private string nombre;
        private DateOnly fecha_inicio;

        

        public Usuario(string nombre, DateOnly fecha_inicio)
        {
            Id = Guid.NewGuid(); // Genera un ID único para cada instancia
            this.nombre = nombre;
            this.fecha_inicio = fecha_inicio;
        }

        public string Nombre { get => nombre; 
            set
            {
                //verifico q el nombre no est vacio
                nombre = !string.IsNullOrWhiteSpace(value) ? value : throw new Exception("El nombre no puede esta vacio");
            }
        }
        public DateOnly Fecha_inicio { get => fecha_inicio; set
            {
                // Valido que la fecha de inicio del usuario no sea en un futuro
                fecha_inicio = value > DateOnly.FromDateTime(DateTime.Now) ? throw new Exception("La fecha de inicio no puede ser en el futuro") : value;
            }
        }

        public Guid Id { get => id; private set => id = value; }
    }
}
