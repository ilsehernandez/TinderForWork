using System;
using System.Collections.Generic;
using TinderForWork.Classes;

namespace TinderForWork.Classes
{
    public partial class TarjetasUsuarios
    {
        public string Matricula { get; set; }
        public string Tarjeta { get; set; }

        public UsuarioInfo MatriculaNavigation { get; set; }
    }
}
