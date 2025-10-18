namespace Library;

public class Reunion : Interaccion
{
    public string Lugar { get; set; }
    public override void AgregarNota(string nota)
    {
        Notas += "\n" + nota;
    }
    
}