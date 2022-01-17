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
    public class HistListModel : PageModel
    {
        private readonly IRepositorioHistoriaClinica repositorioHistorias;
        public IEnumerable<HistoriaClinica> Historias {get;set;}
        [BindProperty]
        public string FiltroBusqueda {get;set;}

        public HistListModel()
        {
            this.repositorioHistorias = new RepositorioHistoriaClinica (new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda=filtroBusqueda;
            Historias=repositorioHistorias.GetHistoriaPorFiltro(filtroBusqueda);
        }
    }
}
