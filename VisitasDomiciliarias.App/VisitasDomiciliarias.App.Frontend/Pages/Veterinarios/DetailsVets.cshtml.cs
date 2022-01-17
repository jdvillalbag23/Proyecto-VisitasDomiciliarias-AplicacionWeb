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
    public class DetailsVetsModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinarios;
        public Veterinario Veterinario { get; set; }
        public DetailsVetsModel()
        {
            this.repositorioVeterinarios = new RepositorioVeterinario(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int veterinarioId)
        {
            Veterinario = repositorioVeterinarios.GetVeterinario(veterinarioId);
            if (Veterinario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
