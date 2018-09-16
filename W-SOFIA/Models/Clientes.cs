using System;
using System.Collections.Generic;

namespace W_SOFIA.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Documentos = new HashSet<Documentos>();
        }

        public int CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string NoIdentificacion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int? CodPais { get; set; }
        public int? CodMunicipio { get; set; }
        public int? CodDepartamento { get; set; }
        public string DireccionEnvio { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string NumeroCuenta { get; set; }
        public int? CodigoTerminosPago { get; set; }
        public bool Credito { get; set; }
        public decimal? LimiteCredito { get; set; }
        public int? IdPrecio { get; set; }
        public string CedularRuc { get; set; }
        public string NombreEmpresa { get; set; }
        public bool Activo { get; set; }

        public Departamentos CodDepartamentoNavigation { get; set; }
        public Municipios CodMunicipioNavigation { get; set; }
        public TerminosPagos CodigoTerminosPagoNavigation { get; set; }
        public ICollection<Documentos> Documentos { get; set; }
    }
}
