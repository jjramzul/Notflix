namespace WebApplication1.Clases
{
    public class Cuenta
    {
        private List<Usuario> l_usuarios;
        private List<Contenido> l_Contenido_visto;

        private string correoElectronico;
        private string contrasena;
        private const int MaxUsuarios = 5;

        public Cuenta(string correoElectronico, string contrasena)
        {
            this.contrasena = contrasena;
            this.correoElectronico = correoElectronico;
            this.L_usuarios = new List<Usuario>()
            {
                new Usuario("Usuario 1", DateOnly.FromDateTime(DateTime.Now)),
                new Usuario("Usuario 2", DateOnly.FromDateTime(DateTime.Now)),
                new Usuario("Usuario 3", DateOnly.FromDateTime(DateTime.Now)),
                new Usuario("Usuario 4", DateOnly.FromDateTime(DateTime.Now)),
                new Usuario("Usuario 5", DateOnly.FromDateTime(DateTime.Now))
            };
        }

        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public List<Usuario> L_usuarios { get => l_usuarios; set => l_usuarios = value; }
        public List<Contenido> L_Contenido_visto { get => l_Contenido_visto; set => l_Contenido_visto = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        public void AgregarUsuario(Usuario usuario)
        {
            // Validamos que el número de usuarios no exceda el máximo de 5 por cuenta
            if (L_usuarios.Count >= MaxUsuarios)
            {
                throw new Exception("No se pueden agregar más de 5 usuarios a la cuenta.");
            }
            else
            {  
                // Agregamos el usuario a la lista
                L_usuarios.Add(usuario);
            }
        }
    }
}
