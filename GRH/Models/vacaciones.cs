//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GRH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vacaciones
    {
        public int id_vacaciones { get; set; }
        public string empleado { get; set; }
        public Nullable<System.DateTime> desde { get; set; }
        public Nullable<System.DateTime> hasta { get; set; }
        public string año { get; set; }
        public string comentarios { get; set; }
    
        public virtual empleado empleado1 { get; set; }
    }
}