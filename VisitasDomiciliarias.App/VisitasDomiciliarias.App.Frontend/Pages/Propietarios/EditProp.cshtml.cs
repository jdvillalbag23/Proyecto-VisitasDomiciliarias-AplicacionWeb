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
    public class EditPropModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietarios;
        [BindProperty]
        public Propietario Propietario { get; set; }
        public EditPropModel()
        {
            this.repositorioPropietarios = new RepositorioPropietario(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? propietarioId)
        {
            if (propietarioId.HasValue)
            {
                Propietario = repositorioPropietarios.GetPropietario(propietarioId.Value);
            }
            else
            {
                Propietario = new Propietario();
            }

            if (Propietario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Propietario.PropietarioId > 0)
            {
                Propietario = repositorioPropietarios.UpdatePropietario(Propietario);
            }
            else
            {
                repositorioPropietarios.AddPropietario(Propietario);
            }
            return RedirectToPage("./PropList");
        }
    }
}
