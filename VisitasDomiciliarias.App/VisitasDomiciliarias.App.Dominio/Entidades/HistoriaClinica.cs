using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VisitasDomiciliarias.App.Dominio
{
    public class HistoriaClinica
    {
        [Key]        
        public int HistoriaId {get; set;}
        [Required(ErrorMessage ="El Campo Temperatura es obligatorio")]
        public double Temperatura{get;set;}
        [Required(ErrorMessage ="El Campo Peso es obligatorio")]
        public double Peso{get;set;}
        [Required(ErrorMessage ="El Campo Frec Respiratoria es obligatorio")]
        public int FrecRespiratoria {get;set;}
        [Required(ErrorMessage ="El Campo Frec. Cardiaca es obligatorio")]
        public int FrecCardiaca {get;set;}
        [Required(ErrorMessage ="El Campo Estado de ánimo es obligatorio"), StringLength(20)]
        public string EstadoAnimo {get;set;}
        [Required(ErrorMessage ="El Campo Fecha de Visita es obligatorio")]
        public DateTime FechaVisita {get;set;}
        [Required(ErrorMessage ="El Campo Recomendaciones es obligatorio"), StringLength(250)]
        public string Recomendaciones {get;set;}
        public int MascotaId { get; set; }
        public Mascota Mascota {get;set;}
        public int VeterinarioId {get;set;}
        public Veterinario Veterinario {get;set;}


    }

}