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
    public class DetailsHistModel : PageModel
    {
        private readonly IRepositorioHistoriaClinica repositorioHistorias;
        public HistoriaClinica Historia {get;set;}
        public DetailsHistModel()
        {
            this.repositorioHistorias = new RepositorioHistoriaClinica(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        
        public IActionResult OnGet(int IdHistoria)
        {
            Historia = repositorioHistorias.GetHistoria(IdHistoria);
            if(Historia==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
