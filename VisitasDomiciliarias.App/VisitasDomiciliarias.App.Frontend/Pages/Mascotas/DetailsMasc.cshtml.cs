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
    public class DetailsMascModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascotas;
        public Mascota Mascota {get; set;}
        public DetailsMascModel()
        {
            this.repositorioMascotas = new RepositorioMascota(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int mascotaId)
        {
            Mascota = repositorioMascotas.GetMascota(mascotaId);
            if(Mascota==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
