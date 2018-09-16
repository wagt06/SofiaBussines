using System;
using System.Collections.Generic;

namespace W_SOFIA.Models
{
    public partial class Municipios
    {
        public Municipios()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int CodMunicipio { get; set; }
        public int? CodDepartamento { get; set; }
        public string Nombre { get; set; }

        public Departamentos CodDepartamentoNavigation { get; set; }
        public ICollection<Clientes> Clientes { get; set; }
    }
}
