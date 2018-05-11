using System;
using System.Collections.Generic;
using TinderForWork.Classes;

namespace TinderForWork.Classes
{
    public partial class HabilidadesUsuario
    {
        public string Matricula { get; set; }
        public string Habilidad { get; set; }

        public UsuarioInfo MatriculaNavigation { get; set; }
    }
}
