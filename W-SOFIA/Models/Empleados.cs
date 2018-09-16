using System;
using System.Collections.Generic;

namespace W_SOFIA.Models
{
    public partial class Empleados
    {
        public Empleados()
        {
            Documentos = new HashSet<Documentos>();
        }

        public int CodigoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public string ImprimirCkaNombre { get; set; }
        public string NumeroAsegurado { get; set; }
        public bool? Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdEstadoMarital { get; set; }
        public int? Ciudadania { get; set; }
        public string Direccion { get; set; }
        public int? CodPais { get; set; }
        public int? CodMunicipio { get; set; }
        public int? CodDepartamento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public decimal? Salario { get; set; }
        public string NumeroCuentaPrestamo { get; set; }
        public string NumeroCuentaNomina { get; set; }
        public string NombreContactoEmergencia { get; set; }
        public string TelefonoContactoEmergencia { get; set; }
        public int? CodCargo { get; set; }
        public int? CodSupervisor { get; set; }
        public int? CodUbicacion { get; set; }
        public bool? Activo { get; set; }

        public ICollection<Documentos> Documentos { get; set; }
    }
}
