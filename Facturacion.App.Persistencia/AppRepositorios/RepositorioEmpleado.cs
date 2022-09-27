using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facturacion.App.Dominio;

namespace Facturacion.App.Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
       private readonly AppContext _appContext;

       public RepositorioEmpleado(AppContext appContext)
       {
            _appContext = appContext;
       }


        
        public Empleado AddEmpleados(Empleado empleado)
        {
            var adicionarEmpleados = _appContext.Empleados.Add(empleado);
            _appContext.SaveChanges();
            return adicionarEmpleados.Entity;
        }

        public IEnumerable<Empleado> GetAllEmpleado()
        {
            return _appContext.Empleados;
        }

        public Empleado GetEmpleados(int Id)
        {
            return _appContext.Empleados.FirstOrDefault(e => e.Id == Id);
        } 

        public Empleado UpdateEmpleados(Empleado empleado)
        {
            var encontrarEmpleado = _appContext.Empleados.FirstOrDefault(e => e.Id == empleado.Id);
            if (encontrarEmpleado != null) {

                encontrarEmpleado.Id = empleado.Id;
                encontrarEmpleado.CodigoEmpleado = empleado.CodigoEmpleado;
                encontrarEmpleado.Cedula = empleado.Cedula;
                encontrarEmpleado.Nombres = empleado.Nombres;
                encontrarEmpleado.Apellidos = empleado.Apellidos;
                encontrarEmpleado.Direccion = empleado.Direccion;
                encontrarEmpleado.FechaNacimiento = empleado.FechaNacimiento;
                encontrarEmpleado.NumeroTelefono = empleado.NumeroTelefono;
                encontrarEmpleado.Correo = empleado.Correo; 

                _appContext.SaveChanges();

            }

            return encontrarEmpleado;
        }

        void IRepositorioEmpleado.DeleteEmpleados(int Id)
        {
            var encontrarEmpleado = _appContext.Empleados.FirstOrDefault(n => n.Id == Id);
            if (encontrarEmpleado == null)
                return;
            _appContext.Empleados.Remove(encontrarEmpleado);
            _appContext.SaveChanges();
        }


    }
}