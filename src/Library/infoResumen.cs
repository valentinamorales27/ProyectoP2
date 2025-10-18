namespace Library
{
    //hay que crear la interfaz interaccion y la clase reunion para que deje de aparecer en rojo
    public class infoResumen
    {
        public int ClientesTotales { get; set; }
        public List<Interaccion> InteraccionesRecientes { get; set; }
        public List<Reunion> ReunionesProximas { get; set; }

        public infoResumen(int clientesTotales, List<Interaccion> interaccionesRecientes, List<Reunion> reunionesProximas)
        {
            this.ClientesTotales = clientesTotales;
            this.InteraccionesRecientes = interaccionesRecientes;
            this.ReunionesProximas = reunionesProximas;
        }
    }
}