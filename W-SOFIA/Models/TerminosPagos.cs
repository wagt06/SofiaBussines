using System;
using System.Collections.Generic;

namespace W_SOFIA.Models
{
    public partial class TerminosPagos
    {
        public TerminosPagos()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int CodTermino { get; set; }
        public string Descripcion { get; set; }
        public int? PlazoDias { get; set; }

        public ICollection<Clientes> Clientes { get; set; }
    }
}
