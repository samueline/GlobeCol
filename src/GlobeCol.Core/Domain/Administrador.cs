using System;
using System.Collections.Generic;

namespace GlobeCol.Web
{
    public partial class Administrador
    {
        public int IdAdministrador { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int? Telefono { get; set; }
    }
}
