using System;
using System.ComponentModel.DataAnnotations;

namespace VisitasDomiciliarias.App.Dominio
{   public class Persona
    {
        
        [Required(ErrorMessage ="El Campo Identificación es obligatorio")]
        public string Identificacion {get ; set;}
        [Required(ErrorMessage ="El Campo Nombres es obligatorio"), StringLength(50)]
        public string Nombres {get ; set;}
        [Required(ErrorMessage ="El Campo Apellidos es obligatorio"), StringLength(50)]
        public string Apellidos {get ; set;}
        [Required(ErrorMessage ="El Campo Teléfono es obligatorio"), StringLength(10)]
        public string Telefono {get ; set;}
   }
}
    