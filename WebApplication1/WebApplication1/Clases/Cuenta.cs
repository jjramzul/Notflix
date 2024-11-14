namespace WebApplication1.Clases
{
    public class Cuenta
    {
        private List<Usuario> l_usuarios;
        private List<Contenido> l_Contenido_visto;

        private string correoElectronico;
        private const int MaxUsuarios = 5;

        public Cuenta(string correoElectronico)
        {
            this.CorreoElectronico = correoElectronico;
            this.l_usuarios = new List<Usuario>();
        }

        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }

        public void AgregarUsuario(Usuario usuario)
        {
            // Validamos que el número de usuarios no exceda el máximo de 5 por cuenta
            if (l_usuarios.Count >= MaxUsuarios)
            {
                throw new Exception("No se pueden agregar más de 5 usuarios a la cuenta.");
            }
            else
            {
                // Verificamos que el correo electrónico del usuario coincida con el de la cuenta
                if (usuario.CorreoElectronico != correoElectronico)
                {
                    throw new Exception("El correo electrónico del usuario debe coincidir con el de la cuenta.");
                }

                // Agregamos el usuario a la lista
                l_usuarios.Add(usuario);
            }
        }
    }
}
