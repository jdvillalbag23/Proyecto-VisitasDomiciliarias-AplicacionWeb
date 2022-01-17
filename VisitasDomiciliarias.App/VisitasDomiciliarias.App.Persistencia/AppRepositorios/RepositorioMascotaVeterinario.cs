using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia.AppRepositorios
{
    public class RepositorioMascotaVeterinario : IRepositorioMascotaVeterinario
    {
        private readonly AppContext _appContext;

        public RepositorioMascotaVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Mascota AsignarMascota(int idVeterinario, int idMascota)
        {
            var veterinario = _appContext.Veterinarios.FirstOrDefault(v => v.VeterinarioId == idVeterinario);
            if (veterinario != null)
            {
                var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.MascotaId == idMascota);
                if (mascotaEncontrada != null)
                {
                    var mascotaVeterinario = new MascotaVeterinario();
                    mascotaVeterinario.MascotaId = mascotaEncontrada.MascotaId;
                    mascotaVeterinario.VeterinarioId = veterinario.VeterinarioId;
                    _appContext.MascotaVeterinarios.Add(mascotaVeterinario);
                    _appContext.SaveChanges();

                }
                return mascotaEncontrada;

            }
            return null;
        }

        public IEnumerable<MascotaVeterinario> GetAll()
        {
            return _appContext.MascotaVeterinarios;
        }        

    }
}