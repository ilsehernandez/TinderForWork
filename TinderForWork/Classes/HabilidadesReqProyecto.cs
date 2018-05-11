using System;
using System.Collections.Generic;
using TinderForWork.Classes;

namespace TinderForWork.Classes
{
    public partial class HabilidadesReqProyecto
    {
        public int ProyectoId { get; set; }
        public string Habilidades { get; set; }

        public ProyectoInfo Proyecto { get; set; }
    }
}
