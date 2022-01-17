using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VisitasDomiciliarias.App.Dominio
{   public class Propietario : Persona
    {
        public int PropietarioId {get;set;}
       
        [Required(ErrorMessage ="El Campo Dirección es obligatorio"), StringLength(40)]
        public string Direccion {get ; set;}
        public List<Mascota> Mascotas {set;get;}
          
    }
}