using System;
using System.Collections.Generic;

namespace GlobeCol.Web
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string RimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public int? CodRol { get; set; }
        public int? IdAdministrador { get; set; }

        public virtual Rol CodRolNavigation { get; set; }
    }
}
