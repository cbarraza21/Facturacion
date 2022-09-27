namespace Facturacion.App.Dominio
{
    public class Factura
    {
        public int Id { get; set; }
        public int NumFactura { get; set; }
        public Cliente Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public String TotalPago { get; set; }             
    }
}