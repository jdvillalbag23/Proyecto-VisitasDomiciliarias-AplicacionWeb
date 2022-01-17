using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VisitasDomiciliarias.App.Dominio
{   public class Veterinario : Persona
    {
        public int VeterinarioId {get;set;}
        
        [Required(ErrorMessage ="El Campo Tarjeta Profesional es obligatorio"), StringLength(15)]
        public string TarjProfesional {get ; set;}
        public List<MascotaVeterinario> MascotasVeterinarios {get;set;}

        public List<HistoriaClinica> Visitas {get;set;}
          
    }
}