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
    public class VetListModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinarios;
        public IEnumerable<Veterinario> Veterinarios {get;set;}
        [BindProperty]
        public string FiltroBusqueda {get;set;}
        public VetListModel()
        {
            this.repositorioVeterinarios = new RepositorioVeterinario( new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda=filtroBusqueda;
            Veterinarios = repositorioVeterinarios.GetVeterinarioPorFiltro(filtroBusqueda);
            //Veterinarios = repositorioVeterinarios.GetAllVeterinarios();
            
        }
    }
}
