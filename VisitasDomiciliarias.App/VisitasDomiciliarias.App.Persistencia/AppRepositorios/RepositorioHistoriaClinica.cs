using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia.AppRepositorios
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext _appContext;
         public RepositorioHistoriaClinica(AppContext appContext)
        {
            _appContext = appContext;
        }
        public HistoriaClinica AddHistoria(HistoriaClinica historia)
        {
            var historiaAdicionada = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionada.Entity;
        }

        public Mascota AsignarMascota(int idHistoria, int idMascota)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(h => h.HistoriaId==idHistoria);
            if(historiaEncontrada!=null)
            {
                var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.MascotaId==idMascota);
                if(mascotaEncontrada!=null)
                {
                    historiaEncontrada.Mascota = mascotaEncontrada;
                    _appContext.SaveChanges();
                }
                return mascotaEncontrada;
            }
            return null;
        }

        public Veterinario AsignarVeterinario(int idHistoria, int idVeterinario)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(h => h.HistoriaId==idHistoria);
            if(historiaEncontrada!=null)
            {
                var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.VeterinarioId==idVeterinario);
                if (veterinarioEncontrado!=null)
                {
                    historiaEncontrada.Veterinario = veterinarioEncontrado;
                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
            }
            return null;
        }

        public void DeleteHistoria(int idHistoria)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(h => h.HistoriaId==idHistoria);
            if(historiaEncontrada==null) return;
            _appContext.Historias.Remove(historiaEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<HistoriaClinica> GetAllHistorias()
        {
            return _appContext.Historias;
        }

        public HistoriaClinica GetHistoria(int idHistoria)
        {
            return _appContext.Historias.FirstOrDefault(h => h.HistoriaId==idHistoria);
        }

        public IEnumerable<HistoriaClinica> GetHistoriaPorFiltro(string filtro = null)
        {
            var historias = GetAllHistorias(); 
            if (historias != null) 
            {
                if (!String.IsNullOrEmpty(filtro)) 
                {
                    historias = historias.Where(h => h.EstadoAnimo.Contains(filtro));
                }
            }
            return historias;
        }

        public Mascota GetMascota(int idHistoria)
        {
            var historia = _appContext.Historias.Where( h => h.HistoriaId == idHistoria)
                                                .Include( h=> h.Mascota)
                                                .FirstOrDefault();

                return historia.Mascota;
        }

        public Veterinario GetVeterinario(int idHistoria)
        {
            var historia = _appContext.Historias.Where( h => h.HistoriaId == idHistoria)
                                                .Include( h=> h.Veterinario)
                                                .FirstOrDefault();

                return historia.Veterinario;
        }

        public HistoriaClinica UpdateHistoria(HistoriaClinica historia)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(h => h.HistoriaId==historia.HistoriaId);
            if (historiaEncontrada!=null)
            {
                historiaEncontrada.Temperatura = historia.Temperatura;
                historiaEncontrada.FrecCardiaca = historia.FrecCardiaca;
                historiaEncontrada.FrecRespiratoria = historia.FrecRespiratoria;
                historiaEncontrada.Peso = historia.Peso;
                historiaEncontrada.EstadoAnimo = historia.EstadoAnimo;
                historiaEncontrada.FechaVisita = historia.FechaVisita;
                historiaEncontrada.Recomendaciones = historia.Recomendaciones;
                historiaEncontrada.Mascota = historia.Mascota;
                historiaEncontrada.Veterinario = historia.Veterinario;
                _appContext.SaveChanges();
            }
            return historiaEncontrada;
        }
    }
}