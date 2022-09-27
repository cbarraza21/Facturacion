using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Facturacion.App.Dominio;
using Facturacion.App.Persistencia;

namespace Facturacion.App.Frontend.Pages
{
    public class ListarEmpleadosModel : PageModel
    {
        private readonly IRepositorioEmpleado repositorioEmpleados;
        public IEnumerable<Empleado> Empleados { get; set; }

        public ListarEmpleadosModel(IRepositorioEmpleado repositorioEmpleados)
        {
            this.repositorioEmpleados = repositorioEmpleados;
        }
        
        public void OnGet()
        {
            Empleados = repositorioEmpleados.GetAllEmpleado();
        }

    }
}
