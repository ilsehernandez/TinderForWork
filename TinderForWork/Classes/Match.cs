using System;
using System.Collections.Generic;
using TinderForWork.Classes;

namespace TinderForWork.Classes
{
    public partial class Match
    {
        public int EstAlumno { get; set; }
        public string Matricula { get; set; }
        public int ProyectoId { get; set; }
        public int MatchId { get; set; }

        public UsuarioInfo MatriculaNavigation { get; set; }
        public ProyectoInfo Proyecto { get; set; }
    }
}
