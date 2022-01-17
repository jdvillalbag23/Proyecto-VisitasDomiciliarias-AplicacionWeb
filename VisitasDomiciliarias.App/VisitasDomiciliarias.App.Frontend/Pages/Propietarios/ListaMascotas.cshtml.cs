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
    public class ListaMascotasModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietarios;
                
        [BindProperty]
        public Propietario Propietario {set;get;}
        public IEnumerable<Mascota> Mascoticas {set;get;}
        

        public ListaMascotasModel()
        {
            this.repositorioPropietarios = new RepositorioPropietario(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }

        public void OnGet(int? idPropietario)
        {
            if(idPropietario.HasValue)
            {
                Propietario = repositorioPropietarios.GetPropietario(idPropietario.Value);
            }

            if (Propietario == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {
                Mascoticas = repositorioPropietarios.GetMascotas(idPropietario.Value);
            }
        }
    }
}
