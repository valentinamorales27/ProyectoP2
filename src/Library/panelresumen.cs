namespace Library
{
    public class PanelResumen
    {
        public vendedor vendedor { get; set; }

        public PanelResumen(vendedor vendedor)
        {
            this.vendedor = vendedor;
        }

        public infoResumen Mostrar()
        {
            return vendedor.VerPanelResumen();//este metodo es de vendedor
        }
    }
}