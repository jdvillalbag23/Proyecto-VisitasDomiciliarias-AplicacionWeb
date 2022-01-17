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
    public class ListMascoticasModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinarios;

        [BindProperty]
        public Veterinario Veterinario { get; set; }
        public IEnumerable<MascotaVeterinario> MascotasVeterinarios {set;get;}
        public ListMascoticasModel()
        {
            this.repositorioVeterinarios = new RepositorioVeterinario(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }

        public void OnGet(int? veterinarioId)
        {
            if(veterinarioId.HasValue)
            {
                Veterinario = repositorioVeterinarios.GetVeterinario(veterinarioId.Value);
            }

            if(Veterinario == null)
            {
                RedirectToPage("./NotFound");
            }

            else
            {
                MascotasVeterinarios = repositorioVeterinarios.GetAllMascotas(veterinarioId.Value);
            }
        }
    }
}
