using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext;
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Veterinario AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        public void DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.VeterinarioId == idVeterinario);
            if (veterinarioEncontrado == null) return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }

        public Veterinario GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(v => v.VeterinarioId == idVeterinario);
        }

        public IEnumerable<Veterinario> GetVeterinarioPorFiltro(string filtro = null)
        {
            var veterinarios = GetAllVeterinarios();
            if (veterinarios != null)
            {
                if (!String.IsNullOrEmpty(filtro))
                {
                    veterinarios = veterinarios.Where(m => m.Nombres.Contains(filtro));
                }
            }
            return veterinarios;
        }

        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.VeterinarioId == veterinario.VeterinarioId);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Nombres = veterinario.Nombres;
                veterinarioEncontrado.Apellidos = veterinario.Apellidos;
                veterinarioEncontrado.Telefono = veterinario.Telefono;
                veterinarioEncontrado.TarjProfesional = veterinario.TarjProfesional;
                _appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }

        public IEnumerable<MascotaVeterinario> GetAllMascotas(int idVeterinario)
        {
            var veterinarios = _appContext.Veterinarios
                                        .Where(m => m.VeterinarioId == idVeterinario)
                                        .Include(m => m.MascotasVeterinarios)
                                        .ThenInclude(x => x.Mascota)
                                        .FirstOrDefault();

            return veterinarios.MascotasVeterinarios;

        }
    }
}