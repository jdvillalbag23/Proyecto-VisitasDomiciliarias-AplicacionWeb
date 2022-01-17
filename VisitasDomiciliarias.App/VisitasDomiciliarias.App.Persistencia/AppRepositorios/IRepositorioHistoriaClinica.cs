using System.Collections.Generic;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHistoriaClinica
    {
        IEnumerable<HistoriaClinica> GetAllHistorias();
        HistoriaClinica AddHistoria(HistoriaClinica historia);
        HistoriaClinica UpdateHistoria(HistoriaClinica historia);
        void DeleteHistoria(int idHistoria);
        HistoriaClinica GetHistoria(int idHistoria);
        Mascota AsignarMascota(int idHistoria, int idMascota);
        Veterinario AsignarVeterinario(int idHistoria, int idVeterinario);
        IEnumerable<HistoriaClinica> GetHistoriaPorFiltro(string filtro);
        Mascota GetMascota(int idHistoria);
        Veterinario GetVeterinario(int idHistoria);
    }
}