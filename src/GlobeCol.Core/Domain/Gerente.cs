using System;
using System.Collections.Generic;

namespace GlobeCol.Web
{
    public partial class Gerente
    {
        public int IdGerente { get; set; }
        public string RimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int? Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
