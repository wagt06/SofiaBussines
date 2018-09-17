using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W_SOFIA.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Documentos = new HashSet<Documentos>();
        }
        [NotMapped]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoCliente { get; set; }

        [Required(ErrorMessage ="El campo Nombre es Necesario")]
        [MaxLength(20, ErrorMessage = "Nombre del Cliente must be 10 characters or less"), MinLength(10)]
        public string NombreCliente { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "BloggerName must be 10 characters or less"), MinLength(5)]
        public string NoIdentificacion { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "BloggerName must be 10 characters or less"), MinLength(5)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "BloggerName must be 10 characters or less"), MinLength(5)]
        public string Celular { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "BloggerName must be 10 characters or less"), MinLength(5)]
        public string Email { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "BloggerName must be 10 characters or less"), MinLength(5)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "BloggerName must be 10 characters or less")]
        public int? CodPais { get; set; }
        [Required]
        public int? CodMunicipio { get; set; }

        [Required]
        public int? CodDepartamento { get; set; }

        [Required]
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
