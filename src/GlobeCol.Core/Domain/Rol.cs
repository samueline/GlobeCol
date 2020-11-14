using System;
using System.Collections.Generic;

namespace GlobeCol.Web
{
    public partial class Rol
    {
        public Rol()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int CodRol { get; set; }
        public string NombreRol { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
