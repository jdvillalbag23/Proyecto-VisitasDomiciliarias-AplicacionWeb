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
    public class DeleteVModel : PageModel
    {     
        private readonly IRepositorioVeterinario repositorioVeterinarios;

        [BindProperty]
        public Veterinario Veterinario { get; set; }
        public DeleteVModel()
        {
            this.repositorioVeterinarios = new RepositorioVeterinario(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? veterinarioId)
        {

            if (veterinarioId.HasValue)
            {
                Veterinario = repositorioVeterinarios.GetVeterinario(veterinarioId.Value);
            }
            
            if (Veterinario == null)
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
            if (Veterinario.VeterinarioId > 0)
            {
                repositorioVeterinarios.DeleteVeterinario(Veterinario.VeterinarioId);
            }            
            return RedirectToPage("./VetList");
        }
    }
}
