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
    public class EditMascModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascotas;
        [BindProperty]
        public Mascota Mascota { get; set; }

        public EditMascModel()
        {
            this.repositorioMascotas = new RepositorioMascota(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? mascotaId)
        {
            if (mascotaId.HasValue)
            {
                Mascota = repositorioMascotas.GetMascota(mascotaId.Value);
            }
            else
            {
                Mascota = new Mascota();
            }
            if (Mascota == null)
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
            if (Mascota.MascotaId > 0)
            {
                Mascota = repositorioMascotas.UpdateMascota(Mascota);
            }
            else
            {
                repositorioMascotas.AddMascota(Mascota);
            }
            return RedirectToPage("./MascList");
        }
    }
}
