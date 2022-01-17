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
    public class MascListModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascotas;
                               
        public IEnumerable<Mascota> Mascotas {get; set;}
        
        [BindProperty]
        public string FiltroBusqueda {get;set;}

        public MascListModel()
        {
            this.repositorioMascotas=new RepositorioMascota(new VisitasDomiciliarias.App.Persistencia.AppContext());
        }
        
        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda=filtroBusqueda;
            Mascotas = repositorioMascotas.GetMascotaPorFiltro(filtroBusqueda);
            //Mascotas = repositorioMascotas.GetAllMascotas();
            
        }
    }
}
