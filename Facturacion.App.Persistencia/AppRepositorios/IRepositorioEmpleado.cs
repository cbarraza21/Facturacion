using System.Collections.Generic;
using System.Diagnostics;
using Facturacion.App.Dominio;

namespace Facturacion.App.Persistencia
{
    public interface IRepositorioEmpleado
    {
        
        Empleado AddEmpleados(Empleado empleado);
        IEnumerable<Empleado> GetAllEmpleado();
        Empleado GetEmpleados(int Id);        
        Empleado UpdateEmpleados(Empleado empleado);
        void DeleteEmpleados(int Id);        
        

    }

}