using System;
using System.Collections.Generic;

namespace W_SOFIA.Models
{
    public partial class Departamentos
    {
        public Departamentos()
        {
            Clientes = new HashSet<Clientes>();
            Municipios = new HashSet<Municipios>();
        }

        public int CodDepartamento { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Clientes> Clientes { get; set; }
        public ICollection<Municipios> Municipios { get; set; }
    }
}
