using System;
using System.Collections.Generic;

namespace GlobeCol.Web
{
    public partial class EmpleadoNovedades
    {
        public int? IdEmpleado { get; set; }
        public int? IdNovedad { get; set; }
        public int? IdAdministrador { get; set; }

        public virtual Administrador IdAdministradorNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Novedades IdNovedadNavigation { get; set; }
    }
}
