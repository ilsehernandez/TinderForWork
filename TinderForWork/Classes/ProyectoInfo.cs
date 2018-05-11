using System;
using System.Collections.Generic;
using TinderForWork.Classes;

namespace TinderForWork.Classes
{
    public partial class ProyectoInfo
    {
        public ProyectoInfo()
        {
            Experiencia = new HashSet<Experiencia>();
            HabilidadesReqProyecto = new HashSet<HabilidadesReqProyecto>();
            Match = new HashSet<Match>();
        }

        public int ProyectoId { get; set; }
        public int HorasTrabajo { get; set; }
        public string NombreProyecto { get; set; }
        public string Descripcion { get; set; }
        public string Campo { get; set; }
        public string Matricula { get; set; }

        public HorasServicioDadas HorasServicioDadas { get; set; }
        public PagoProj PagoProj { get; set; }
        public ICollection<Experiencia> Experiencia { get; set; }
        public ICollection<HabilidadesReqProyecto> HabilidadesReqProyecto { get; set; }
        public ICollection<Match> Match { get; set; }
    }
}
