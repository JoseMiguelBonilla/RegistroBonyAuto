using System.ComponentModel.DataAnnotations;
namespace RegistroBonyAuto.Models
{
    public class Prioridad
    {
        [Key] //KEY ES EL ID CODE PARA NUESTRA BASE DE DATOS, (LOS ATRIBUTOS DEBEN INICIAR EN MAYUSCULA)
        public int PrioridadId {get; set;}
        [Required(ErrorMessage ="La descripcion es obligatoria")]
        public string Descripcion {get; set;}
        [Required(ErrorMessage ="Los dias de compromiso son obligatoria")]
        public int DiasCompromiso {get; set;}
       
       //aqui se agregaria otro requiride si existiera otro identicador, recordar que primero va la descripcion y luego el atributo
        
    }
}