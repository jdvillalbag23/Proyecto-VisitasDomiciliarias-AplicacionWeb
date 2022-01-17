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
    public class VetHistModel : PageModel
    {
        private readonly IRepositorioHistoriaClinica repositorioHistorias;
        [BindProperty]
        public HistoriaClinica Historia {set;get;}
        [BindProperty]
        public Veterinario Veterinario {set; get;}
        
        public VetHistModel()
        {
            this.repositorioHistorias = new RepositorioHistoriaClinica(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public void OnGet(int? idHistoria)
        {
            if(idHistoria.HasValue)
            {
                Historia = repositorioHistorias.GetHistoria(idHistoria.Value);
            }
            if (Historia == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {
                Veterinario = repositorioHistorias.GetVeterinario(idHistoria.Value);
            }
        }
    }
}
