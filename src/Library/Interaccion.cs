namespace Library;

public abstract class Interaccion
{
    public DateTime Fecha { get; set; }
    public string Tema { get; set; }
    public string Notas { get; set; }
    public string Tipo { get; set; }
    public bool EnviadaDesdeUsuario { get; set; }


    public abstract void AgregarNota(string nota);
    
}