using System;
using System.Collections.Generic;

namespace GlobeCol.Web
{
    public partial class EmpleadoCertificaciones
    {
        public int? IdCertificacion { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdGerente { get; set; }

        public virtual Certificaciones IdCertificacionNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Gerente IdGerenteNavigation { get; set; }
    }
}
