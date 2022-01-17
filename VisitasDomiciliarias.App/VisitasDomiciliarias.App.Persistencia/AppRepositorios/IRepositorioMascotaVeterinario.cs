using System.Collections.Generic;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascotaVeterinario
    {
        IEnumerable<MascotaVeterinario> GetAll();                
        Mascota AsignarMascota(int idVeterinario, int idMascota);
        
    }
}