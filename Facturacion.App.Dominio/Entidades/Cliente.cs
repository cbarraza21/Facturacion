namespace Facturacion.App.Dominio
{
    public class Cliente:Persona
    {           
        public List<Factura> Facturas { get; set; }                    
    }
}