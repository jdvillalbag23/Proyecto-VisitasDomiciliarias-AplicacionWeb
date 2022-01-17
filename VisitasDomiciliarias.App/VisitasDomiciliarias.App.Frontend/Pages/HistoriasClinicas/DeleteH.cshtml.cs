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
    public class DeleteHModel : PageModel
    {
        private readonly IRepositorioHistoriaClinica repositorioHistorias;
        [BindProperty]
        public HistoriaClinica Historia { get; set; }
        public DeleteHModel()
        {
            this.repositorioHistorias = new RepositorioHistoriaClinica( new VisitasDomiciliarias.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? IdHistoria)
        {
            if (IdHistoria.HasValue)
            {
                Historia = repositorioHistorias.GetHistoria(IdHistoria.Value);
            }
            
            if (Historia == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Historia.HistoriaId>0)
            {
                repositorioHistorias.DeleteHistoria(Historia.HistoriaId);
            }            
            return RedirectToPage("./HistList");
        }
    }
}
