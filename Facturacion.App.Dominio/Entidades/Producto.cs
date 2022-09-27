namespace Facturacion.App.Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public String Precio { get; set; } 
        public int Stock { get; set; }
        public String Descripcion { get; set; } 

    }
}