using System.Collections.Generic;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
        IEnumerable<Mascota> GetMascotaPorFiltro(string filtro);
        Propietario GetPropietario(int idMascota);
        //IEnumerable<Veterinario> AsignarVeterinario(int idMascota, int idVeterinario);
        IEnumerable<MascotaVeterinario> GetAllVeterinarios(int idMascota);
    }
}