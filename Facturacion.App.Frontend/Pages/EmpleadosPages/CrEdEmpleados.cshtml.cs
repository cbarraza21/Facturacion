using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Facturacion.App.Dominio;
using Facturacion.App.Persistencia;

namespace Facturacion.App.Frontend.Pages
{
    public class CrEdEmpleadosModel : PageModel
    {
        private readonly IRepositorioEmpleado repositorioEmpleados;

        public Empleado empleado1 { get; set; }

        public CrEdEmpleadosModel(IRepositorioEmpleado repositorioEmpleados){
            this.repositorioEmpleados = repositorioEmpleados;
        }
        public IActionResult OnGet(int? Id)
        {
            if(Id.HasValue)
            {
                empleado1 = repositorioEmpleados.GetEmpleados(Id.Value);
            }
            else
            {
                empleado1 = new Empleado();
            }

            if(empleado1==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }


        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(empleado1.Id>0)
            {
                empleado1 = repositorioEmpleados.UpdateEmpleados(empleado1);
            }
            else
            {
                repositorioEmpleados.AddEmpleados(empleado1);
            }
            return Page();
        }
    }
}
