using System;
using System.Collections.Generic;

namespace W_SOFIA.Models
{
    public partial class DocumentosDetalles
    {
        public int Numero { get; set; }
        public int CodSucursal { get; set; }
        public int CodFactura { get; set; }
        public string TipoDoc { get; set; }
        public bool EsCredito { get; set; }
        public string Serie { get; set; }
        public string Upc { get; set; }
        public string Sku { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Total { get; set; }
        public decimal? SubTotal { get; set; }

        public Documentos Documentos { get; set; }
    }
}
