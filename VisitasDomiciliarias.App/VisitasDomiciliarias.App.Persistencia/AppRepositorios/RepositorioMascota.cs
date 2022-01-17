using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext _appContext;
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Mascota AddMascota(Mascota mascota)
        {
            var mascotaAdicionada = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }

        // public IEnumerable<Veterinario> AsignarVeterinario(int idMascota, int idVeterinario)
        // {
        //     var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.MascotaId==idMascota);
        //     if(mascotaEncontrada!=null)
        //     {
        //         var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.VeterinarioId==idVeterinario);
        //         if(veterinarioEncontrado!=null)
        //         {
        //             mascotaEncontrada.Veterinarios.Add(veterinarioEncontrado);                    
        //             _appContext.SaveChanges();                    
        //         }
        //         return mascotaEncontrada.Veterinarios;
        //     } 
        //     return null;
        // }

        public void DeleteMascota(int idMascota)
        {
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.MascotaId == idMascota);
            if (mascotaEncontrada == null) return;
            _appContext.Mascotas.Remove(mascotaEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _appContext.Mascotas;
        }

        public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(m => m.MascotaId == idMascota);
        }

        public IEnumerable<Mascota> GetMascotaPorFiltro(string filtro = null)
        {
            var mascotas = GetAllMascotas();
            if (mascotas != null)
            {
                if (!String.IsNullOrEmpty(filtro))
                {
                    mascotas = mascotas.Where(m => m.Nombre.Contains(filtro));
                }
            }
            return mascotas;
        }

        public Propietario GetPropietario(int idMascota)
        {
            var mascota = _appContext.Mascotas.Where(m => m.MascotaId == idMascota)
                                                      .Include(m => m.Propietario)
                                                      .FirstOrDefault();
            return mascota.Propietario;
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.MascotaId == mascota.MascotaId);
            if (mascotaEncontrada != null)
            {
                mascotaEncontrada.Nombre = mascota.Nombre;
                mascotaEncontrada.Raza = mascota.Raza;
                mascotaEncontrada.Edad = mascota.Edad;
                mascotaEncontrada.Tipo = mascota.Tipo;
                mascotaEncontrada.Genre = mascota.Genre;
                mascotaEncontrada.PropietarioId = mascota.PropietarioId;
                //mascotaEncontrada.Veterinarios = mascota.Veterinarios;
                _appContext.SaveChanges();
            }
            return mascotaEncontrada;
        }

        public IEnumerable<MascotaVeterinario> GetAllVeterinarios(int idMascota)
        {
            var mascotas =  _appContext.Mascotas
                                        .Where(m => m.MascotaId == idMascota)
                                        .Include(m => m.MascotasVeterinarios)
                                        .ThenInclude( x => x.Veterinario)                                                                                                                                        
                                        .FirstOrDefault();

            return mascotas.MascotasVeterinarios;
            
        }
    }
}