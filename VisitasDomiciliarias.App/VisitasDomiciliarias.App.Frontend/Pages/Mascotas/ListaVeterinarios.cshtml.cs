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
    public class ListaVeterinariosModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascotas;
        [BindProperty]
        public Mascota Mascota {set;get;}        
        public IEnumerable<MascotaVeterinario> MascotasVeterinarios {set;get;}
        public ListaVeterinariosModel()
        {
            this.repositorioMascotas = new RepositorioMascota( new VisitasDomiciliarias.App.Persistencia.AppContext());
        }

        public void OnGet(int? mascotaId)
        {
            if(mascotaId.HasValue)
            {
                Mascota = repositorioMascotas.GetMascota(mascotaId.Value);
            }

            if(mascotaId == null)
            {
                RedirectToPage("./NotFound");
            }

            else
            {
                MascotasVeterinarios = repositorioMascotas.GetAllVeterinarios(mascotaId.Value);
            }
        }
    }
}
