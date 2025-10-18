namespace Library;

public class ventas
{
    public string Producto_servicio { get; set; }
    public DateTime Fecha { get; set; }
    public double Monto { get; set; }
    public ventas(string producto_servicio, DateTime fecha, double monto)
    {
        this.Producto_servicio = producto_servicio;
        this.Fecha = fecha;
        this.Monto = monto;
    }
}