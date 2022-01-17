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
    public class PropListModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietarios;
        public IEnumerable<Propietario> Propietarios {get; set;}
        [BindProperty]
        public string FiltroBusqueda {get; set;}
        public PropListModel()
        {
            this.repositorioPropietarios= new RepositorioPropietario( new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda=filtroBusqueda;
            Propietarios=repositorioPropietarios.GetPropietarioPorFiltro(filtroBusqueda);           
        }
    }
}
