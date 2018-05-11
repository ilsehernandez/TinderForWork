using System;
using System.Collections.Generic;
using TinderForWork.Classes;

namespace TinderForWork.Classes
{
    public partial class Experiencia
    {
        public string Matricula { get; set; }
        public int ProyectoId { get; set; }

        public UsuarioInfo MatriculaNavigation { get; set; }
        public ProyectoInfo Proyecto { get; set; }
    }
}
