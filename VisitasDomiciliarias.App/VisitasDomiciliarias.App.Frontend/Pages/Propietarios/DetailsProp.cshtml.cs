using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VisitasDomiciliarias.App.Dominio;
using VisitasDomiciliarias.App.Persistencia.AppRepositorios;

namespace VisitasDomiciliarias.App.Frontend.Pages
{
    public class DetailsPropModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietarios;
        public Propietario Propietario {get;set;}
        public DetailsPropModel()
        {
            this.repositorioPropietarios= new RepositorioPropietario(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int propietarioId)
        {
            Propietario = repositorioPropietarios.GetPropietario(propietarioId);
            if(Propietario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
