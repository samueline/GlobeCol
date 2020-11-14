using System;
using System.Collections.Generic;

namespace GlobeCol.Web
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int? Telefono { get; set; }
        public string Direccion { get; set; }
        public int? CodHorario { get; set; }

        public virtual MallaHoraria CodHorarioNavigation { get; set; }
    }
}
