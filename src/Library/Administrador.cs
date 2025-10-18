namespace Library;

public class Administrador : Usuario
{
    public Usuario CrearUsuario(string nombre, string apellido, string correo)
    {
        Usuario NuevoUsuario = new Usuario
        {
            Nombre = nombre,
            Apellido = apellido,
            Correo = correo,
            EstaSuspendido = false
        };
        return NuevoUsuario;
    }

    public void SuspenderUsuario(Usuario usuario)
    {
        usuario.EstaSuspendido = true;
    }

    public void EliminarUsuario(Usuario usuario)
    {
        
    }
}