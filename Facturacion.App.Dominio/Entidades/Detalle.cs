namespace Facturacion.App.Dominio
{
    public class Detalle
    {
        public int NumDetalle { get; set; }
        public Factura NumFactura { get; set; }
        public Producto Codigo { get; set; }
        public int Cantidad { get; set; }
        public Producto Precio { get; set; }            
    }
}