using System;
using System.Collections.Generic;
using TinderForWork.Classes;

namespace TinderForWork.Classes
{
    public partial class PagoProj
    {
        public int Idproyecto { get; set; }
        public decimal Pago { get; set; }

        public ProyectoInfo IdproyectoNavigation { get; set; }
    }
}
