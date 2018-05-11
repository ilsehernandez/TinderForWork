using System;
using System.Collections.Generic;
using TinderForWork.Classes;

namespace TinderForWork.Classes
{
    public partial class HorasServicioDadas
    {
        public int Idproyecto { get; set; }
        public int HorasServicio { get; set; }

        public ProyectoInfo IdproyectoNavigation { get; set; }
    }
}
