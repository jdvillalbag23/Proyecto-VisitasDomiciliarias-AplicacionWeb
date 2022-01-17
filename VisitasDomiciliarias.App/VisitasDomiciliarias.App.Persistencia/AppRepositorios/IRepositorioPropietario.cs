using System.Collections.Generic;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    {
         IEnumerable<Propietario> GetAllPropietarios();
         Propietario AddPropietario(Propietario propietario);
         Propietario UpdatePropietario(Propietario propietario);
         void DeletePropietario (int idPropietario);
         Propietario GetPropietario (int idPropietario);
         IEnumerable<Propietario> GetPropietarioPorFiltro(string filtro);
         IEnumerable<Mascota> GetMascotas(int idPropietario);
         
    }
}