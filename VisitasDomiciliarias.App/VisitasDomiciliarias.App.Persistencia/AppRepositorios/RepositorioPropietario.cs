using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
        private readonly AppContext _appContext;


        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Propietario AddPropietario(Propietario propietario)
        {
            var propietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        public void DeletePropietario(int idPropietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.PropietarioId == idPropietario);
            if (propietarioEncontrado == null) return;
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Propietario> GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }

        public IEnumerable<Mascota> GetMascotas(int idPropietario)
        {
            var propietario = _appContext.Propietarios.Where(p => p.PropietarioId == idPropietario)
                                                      .Include(p => p.Mascotas)
                                                      .FirstOrDefault();
            return propietario.Mascotas;
        }

        public Propietario GetPropietario(int idPropietario)
        {
            return _appContext.Propietarios.FirstOrDefault(p => p.PropietarioId == idPropietario);
        }

        public IEnumerable<Propietario> GetPropietarioPorFiltro(string filtro = null)
        {
            var propietarios = GetAllPropietarios();
            if (propietarios != null)
            {
                if (!String.IsNullOrEmpty(filtro))
                {
                    propietarios = propietarios.Where(m => m.Nombres.Contains(filtro));
                }
            }
            return propietarios;
        }

        public Propietario UpdatePropietario(Propietario propietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.PropietarioId == propietario.PropietarioId);
            if (propietarioEncontrado != null)
            {
                propietarioEncontrado.Nombres = propietario.Nombres;
                propietarioEncontrado.Apellidos = propietario.Apellidos;
                propietarioEncontrado.Direccion = propietario.Direccion;
                propietarioEncontrado.Telefono = propietario.Telefono;
                _appContext.SaveChanges();
            }
            return propietarioEncontrado;
        }
    }
}