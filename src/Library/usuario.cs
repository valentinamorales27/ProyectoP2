using System.Runtime.CompilerServices;

namespace Library;

public class usuario
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public bool Suspendido { get; set; }
    public usuario(string nombre, string apellido, string correo, bool suspendido)
    {
        this.Apellido = apellido;
        this.Correo = correo;
        this.Suspendido = suspendido;
        this.Nombre = nombre;
    }
}