using System;
using System.Collections.Generic;

namespace W_SOFIA.Models
{
    public partial class Documentos
    {
        public Documentos()
        {
            DocumentosDetalles = new HashSet<DocumentosDetalles>();
        }

        public int CodSucursal { get; set; }
        public int CodFactura { get; set; }
        public string TipoDoc { get; set; }
        public bool EsCredito { get; set; }
        public string Serie { get; set; }
        public int? CodCliente { get; set; }
        public int? CodVendedor { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Iva { get; set; }
        public decimal? TotalFactura { get; set; }
        public DateTime? FechaVence { get; set; }
        public decimal? Abono { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Costo { get; set; }
        public int? CodSucursalPed { get; set; }
        public int? CodPed { get; set; }
        public int? CodTipoDocPed { get; set; }
        public bool? EsCreditoPed { get; set; }
        public string SeriePed { get; set; }
        public bool? CodVendedorPed { get; set; }

        public Clientes CodClienteNavigation { get; set; }
        public Empleados CodVendedorNavigation { get; set; }
        public ICollection<DocumentosDetalles> DocumentosDetalles { get; set; }
    }
}
