//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TinderForWork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Match
    {
        public int EstAlumno { get; set; }
        public string Matricula { get; set; }
        public int ProyectoID { get; set; }
        public int MatchID { get; set; }
    
        public virtual ProyectoInfo ProyectoInfo { get; set; }
        public virtual UsuarioInfo UsuarioInfo { get; set; }
    }
}
