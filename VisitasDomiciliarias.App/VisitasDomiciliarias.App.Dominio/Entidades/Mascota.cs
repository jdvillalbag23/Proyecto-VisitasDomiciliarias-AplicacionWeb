using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VisitasDomiciliarias.App.Dominio
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        
        [Required(ErrorMessage = "El Campo Nombre es obligatorio"), StringLength(50)]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El Campo Raza es obligatorio"), StringLength(20)]
        public string Raza { get; set; }
        [Required(ErrorMessage ="El Campo Edad es obligatorio")]
        public double Edad { get; set; }
        [Required(ErrorMessage ="El Campo Tipo es obligatorio")]
        public Tipo Tipo { get; set; }
        public Sexo Genre {set;get;}
        
        public int PropietarioId {get;set;}
        public Propietario Propietario {get;set;}
        public List<HistoriaClinica> Visita {get;set;}
        public List<MascotaVeterinario> MascotasVeterinarios {get;set;}
        

    }
}