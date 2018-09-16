using System;
using System.Collections.Generic;

namespace W_SOFIA.Models
{
    public partial class Proveedores
    {
        public int CodigoProveedor { get; set; }
        public string CedularRuc { get; set; }
        public string RazonSocial { get; set; }
        public string ImprimirCkaNombre { get; set; }
        public int? CodRepresentante { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int? CodPais { get; set; }
        public int? CodMunicipio { get; set; }
        public int? CodDepartamento { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string NumeroCuentaXp { get; set; }
        public string NumeroCuentaXc { get; set; }
        public int? CodigoTerminosPago { get; set; }
        public decimal? LimiteCredito { get; set; }
        public bool? Credito { get; set; }
        public string NombreEmpresa { get; set; }
        public bool? Activo { get; set; }
        public int? TipoProveedor { get; set; }
    }
}
