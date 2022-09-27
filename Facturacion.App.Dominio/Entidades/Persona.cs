namespace Facturacion.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public String Cedula { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }                
        public String NumeroTelefono { get; set; } 
        public String Correo { get; set; }
                           
    }
}