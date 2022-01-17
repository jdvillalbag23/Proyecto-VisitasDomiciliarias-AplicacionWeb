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
    public class OwnerModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        [BindProperty]
        public Mascota Mascota {set;get;}
        public Propietario Propietario {set;get;}
        public OwnerModel()
        {
            this.repositorioMascota = new RepositorioMascota(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public void OnGet(int? mascotaId)
        {
            if(mascotaId.HasValue)
            {
                Mascota = repositorioMascota.GetMascota(mascotaId.Value);
            }

            if(Mascota == null)
            {
                RedirectToPage("./NotFound");
            }

            else
            {
                Propietario = repositorioMascota.GetPropietario(mascotaId.Value);
            }
        }
    }
}
