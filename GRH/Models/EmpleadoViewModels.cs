using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GRH.Models
{
    public class EmpleadoViewModels
    {
        public int id_empleado { get; set; }
        [Required]
        [StringLength(5)]
        [Display(Name ="Codigo Empleado")]
        public string codigo_empleado { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }
        [StringLength(12)]
        [Display(Name = "Telefono")]
        public string telefono { get; set; }
        [Required]
        [Display(Name = "Departamento")]
        public string departamento { get; set; }
        [Required]
        [Display(Name = "Cargo")]
        public string cargo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime fecha_ingreso { get; set; }
        [Required]
        [Display(Name = "Salario")]
        public decimal salario { get; set; }
        [Required]
        [Display(Name = "Estatus")]
        public Estado estatus { get; set; }
        
    }
    public enum Estado { Activo, Inactivo }
}
