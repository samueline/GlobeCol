using System;
using System.Collections.Generic;

namespace GlobeCol.Web
{
    public partial class MallaHoraria
    {
        public MallaHoraria()
        {
            Empleado = new HashSet<Empleado>();
        }

        public int CodHorario { get; set; }
        public DateTime? HorarioJornada { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
