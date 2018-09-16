using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace W_SOFIA.Models
{
    public partial class SOFIAContext : DbContext
    {
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<DocumentosDetalles> DocumentosDetalles { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<TerminosPagos> TerminosPagos { get; set; }

        // Unable to generate entity type for table 'dbo.Inventario'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Almacenes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sucursales'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cargos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Ubicaciones'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Inventario_Almacen'. Please see the warning messages.
        // Unable to generate entity type for table 'Seguridad.Usuario'. Please see the warning messages.
        // Unable to generate entity type for table 'Seguridad.Menu'. Please see the warning messages.
        // Unable to generate entity type for table 'Seguridad.Permisos'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DD3LKCK\MSSQLSOFIA;Initial Catalog=SOFIA;user=sa;Password=sofia;Persist Security Info=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.CodigoCliente);

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.CedularRuc).HasMaxLength(20);

                entity.Property(e => e.Celular).HasMaxLength(10);

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.DireccionEnvio).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.IdPrecio).HasColumnName("idPrecio");

                entity.Property(e => e.LimiteCredito).HasColumnType("money");

                entity.Property(e => e.NoIdentificacion).HasMaxLength(20);

                entity.Property(e => e.NombreCliente).HasMaxLength(150);

                entity.Property(e => e.NombreEmpresa).HasMaxLength(100);

                entity.Property(e => e.NumeroCuenta).HasMaxLength(100);

                entity.Property(e => e.Telefono).HasMaxLength(10);

                entity.HasOne(d => d.CodDepartamentoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CodDepartamento)
                    .HasConstraintName("FK_Clientes_Departamentos");

                entity.HasOne(d => d.CodMunicipioNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CodMunicipio)
                    .HasConstraintName("FK_Clientes_Municipios");

                entity.HasOne(d => d.CodigoTerminosPagoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CodigoTerminosPago)
                    .HasConstraintName("FK_Clientes_TerminosPagos");
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.CodDepartamento);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Documentos>(entity =>
            {
                entity.HasKey(e => new { e.CodSucursal, e.CodFactura, e.TipoDoc, e.EsCredito });

                entity.Property(e => e.TipoDoc)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Abono).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaVence).HasColumnType("datetime");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.Serie).HasMaxLength(1);

                entity.Property(e => e.SeriePed).HasMaxLength(1);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.TotalFactura).HasColumnType("money");

                entity.HasOne(d => d.CodClienteNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.CodCliente)
                    .HasConstraintName("FK_Documentos_Clientes");

                entity.HasOne(d => d.CodVendedorNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.CodVendedor)
                    .HasConstraintName("FK_Documentos_Empleados");
            });

            modelBuilder.Entity<DocumentosDetalles>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.CodSucursal, e.CodFactura, e.TipoDoc, e.EsCredito });

                entity.ToTable("Documentos_Detalles");

                entity.Property(e => e.TipoDoc)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Serie).HasMaxLength(1);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.Documentos)
                    .WithMany(p => p.DocumentosDetalles)
                    .HasForeignKey(d => new { d.CodSucursal, d.CodFactura, d.TipoDoc, d.EsCredito })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documentos_Detalles_Documentos");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.CodigoEmpleado);

                entity.Property(e => e.Celular).HasMaxLength(10);

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.ImprimirCkaNombre)
                    .HasColumnName("ImprimirCKaNombre")
                    .HasMaxLength(150);

                entity.Property(e => e.MotivoBaja).HasMaxLength(150);

                entity.Property(e => e.NombreContactoEmergencia).HasMaxLength(60);

                entity.Property(e => e.NombreEmpleado).HasMaxLength(150);

                entity.Property(e => e.NumeroAsegurado).HasMaxLength(20);

                entity.Property(e => e.NumeroCuentaNomina).HasMaxLength(20);

                entity.Property(e => e.NumeroCuentaPrestamo).HasMaxLength(20);

                entity.Property(e => e.Salario).HasColumnType("money");

                entity.Property(e => e.Telefono).HasMaxLength(10);

                entity.Property(e => e.TelefonoContactoEmergencia).HasMaxLength(60);
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.HasKey(e => e.CodMunicipio);

                entity.Property(e => e.CodMunicipio).ValueGeneratedNever();

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.HasOne(d => d.CodDepartamentoNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.CodDepartamento)
                    .HasConstraintName("FK_Municipios_Departamentos");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.CodPais);

                entity.Property(e => e.CodPais).ValueGeneratedNever();

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.CodigoProveedor);

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.CedularRuc).HasMaxLength(20);

                entity.Property(e => e.Celular).HasMaxLength(10);

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.ImprimirCkaNombre)
                    .HasColumnName("ImprimirCKaNombre")
                    .HasMaxLength(150);

                entity.Property(e => e.LimiteCredito).HasColumnType("money");

                entity.Property(e => e.NombreEmpresa).HasMaxLength(100);

                entity.Property(e => e.NumeroCuentaXc)
                    .HasColumnName("NumeroCuentaXC")
                    .HasMaxLength(100);

                entity.Property(e => e.NumeroCuentaXp)
                    .HasColumnName("NumeroCuentaXP")
                    .HasMaxLength(100);

                entity.Property(e => e.RazonSocial).HasMaxLength(150);

                entity.Property(e => e.Telefono).HasMaxLength(10);
            });

            modelBuilder.Entity<TerminosPagos>(entity =>
            {
                entity.HasKey(e => e.CodTermino);

                entity.Property(e => e.Descripcion).HasMaxLength(20);
            });
        }
    }
}
