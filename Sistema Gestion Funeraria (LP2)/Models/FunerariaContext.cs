using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class FunerariaContext : DbContext
{
    public FunerariaContext()
    {
    }

    public FunerariaContext(DbContextOptions<FunerariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Atributo> Atributos { get; set; }

    public virtual DbSet<AtributoCategoria> AtributoCategorias { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Defuncione> Defunciones { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<FacturacionesAtributo> FacturacionesAtributos { get; set; }

    public virtual DbSet<FacturacionesServicio> FacturacionesServicios { get; set; }

    public virtual DbSet<JornadaLaboral> JornadaLaborals { get; set; }

    public virtual DbSet<LibroFirma> LibroFirmas { get; set; }

    public virtual DbSet<Localidad> Localidads { get; set; }

    public virtual DbSet<Sala> Salas { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<ServiciosCategoria> ServiciosCategorias { get; set; }

    public virtual DbSet<TipoIdentificacion> TipoIdentificacions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=EMMANUELG\\SQLEXPRESS01;Database=Funeraria;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atributo>(entity =>
        {
            entity.HasKey(e => e.IdAtributo).HasName("PK__Atributo__5ECA4A18BB222385");

            entity.ToTable("Atributo");

            entity.Property(e => e.IdAtributo).HasColumnName("ID_Atributo");
            entity.Property(e => e.Costo).HasColumnType("money");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<AtributoCategoria>(entity =>
        {
            entity.HasKey(e => new { e.IdAtributo, e.IdCategoria }).HasName("PK__Atributo__1EE0EA60110EB8E8");

            entity.ToTable("Atributo_Categorias");

            entity.Property(e => e.IdAtributo).HasColumnName("ID_Atributo");
            entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");
            entity.Property(e => e.Costo).HasColumnType("money");

            entity.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.AtributoCategoria)
                .HasForeignKey(d => d.IdAtributo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atributo___ID_At__5812160E");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.AtributoCategoria)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atributo___ID_Ca__59063A47");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("PK__Cargo__8D69B95FF32F368A");

            entity.ToTable("Cargo");

            entity.Property(e => e.IdCargo).HasColumnName("ID_Cargo");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__02AA0785BC6EFF8D");

            entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.TotalCobertura)
                .HasColumnType("money")
                .HasColumnName("Total_Cobertura");
        });

        modelBuilder.Entity<Defuncione>(entity =>
        {
            entity.HasKey(e => e.IdDefuncion).HasName("PK__Defuncio__E05EBEA8E2AD1090");

            entity.Property(e => e.IdDefuncion).HasColumnName("ID_Defuncion");
            entity.Property(e => e.CertificacionDefuncion)
                .HasColumnType("image")
                .HasColumnName("Certificacion_Defuncion");
            entity.Property(e => e.FechaFallecimiento).HasColumnName("Fecha_Fallecimiento");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.HorarioEntrada).HasColumnName("Horario_Entrada");
            entity.Property(e => e.HorarioSalida).HasColumnName("Horario_Salida");
            entity.Property(e => e.IdIdentificacion).HasColumnName("ID_Identificacion");
            entity.Property(e => e.IdSala).HasColumnName("ID_Sala");
            entity.Property(e => e.Identificacion).HasMaxLength(11);
            entity.Property(e => e.NombreDifunto)
                .HasMaxLength(100)
                .HasColumnName("Nombre_Difunto");
            entity.Property(e => e.Representante).HasMaxLength(100);
            entity.Property(e => e.RepresentanteDireccion)
                .HasMaxLength(200)
                .HasColumnName("Representante_Direccion");
            entity.Property(e => e.RepresentanteTelefono)
                .HasMaxLength(9)
                .HasColumnName("Representante_Telefono");

            entity.HasOne(d => d.IdIdentificacionNavigation).WithMany(p => p.Defunciones)
                .HasForeignKey(d => d.IdIdentificacion)
                .HasConstraintName("FK__Defuncion__ID_Id__6477ECF3");

            entity.HasOne(d => d.IdSalaNavigation).WithMany(p => p.Defunciones)
                .HasForeignKey(d => d.IdSala)
                .HasConstraintName("FK__Defuncion__ID_Sa__6383C8BA");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__B7872C903D140D56");

            entity.Property(e => e.IdEmpleado).HasColumnName("ID_Empleado");
            entity.Property(e => e.Direccion).HasMaxLength(200);
            entity.Property(e => e.IdCargo).HasColumnName("ID_Cargo");
            entity.Property(e => e.IdIdentificacion).HasColumnName("ID_Identificacion");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.NumDocumento).HasMaxLength(11);
            entity.Property(e => e.Telefono).HasMaxLength(9);

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdCargo)
                .HasConstraintName("FK__Empleados__ID_Ca__6A30C649");

            entity.HasOne(d => d.IdIdentificacionNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdIdentificacion)
                .HasConstraintName("FK__Empleados__ID_Id__693CA210");
        });

        modelBuilder.Entity<FacturacionesAtributo>(entity =>
        {
            entity.HasKey(e => new { e.IdAtributo, e.IdDefuncion }).HasName("PK__Facturac__C0CFA1F218B18465");

            entity.ToTable("Facturaciones_Atributo");

            entity.Property(e => e.IdAtributo).HasColumnName("ID_Atributo");
            entity.Property(e => e.IdDefuncion).HasColumnName("ID_Defuncion");
            entity.Property(e => e.Costo).HasColumnType("money");

            entity.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.FacturacionesAtributos)
                .HasForeignKey(d => d.IdAtributo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Facturaci__ID_At__73BA3083");

            entity.HasOne(d => d.IdDefuncionNavigation).WithMany(p => p.FacturacionesAtributos)
                .HasForeignKey(d => d.IdDefuncion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Facturaci__ID_De__74AE54BC");
        });

        modelBuilder.Entity<FacturacionesServicio>(entity =>
        {
            entity.HasKey(e => new { e.IdServicio, e.IdDefuncion }).HasName("PK__Facturac__87371E6E599590DE");

            entity.ToTable("Facturaciones_Servicios");

            entity.Property(e => e.IdServicio).HasColumnName("ID_Servicio");
            entity.Property(e => e.IdDefuncion).HasColumnName("ID_Defuncion");
            entity.Property(e => e.Costo).HasColumnType("money");

            entity.HasOne(d => d.IdDefuncionNavigation).WithMany(p => p.FacturacionesServicios)
                .HasForeignKey(d => d.IdDefuncion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Facturaci__ID_De__787EE5A0");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.FacturacionesServicios)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Facturaci__ID_Se__778AC167");
        });

        modelBuilder.Entity<JornadaLaboral>(entity =>
        {
            entity.HasKey(e => e.IdJornadaLaboral).HasName("PK__Jornada___4D953981BDABBB99");

            entity.ToTable("Jornada_Laboral");

            entity.Property(e => e.IdJornadaLaboral).HasColumnName("ID_Jornada_Laboral");
            entity.Property(e => e.FechaEntrada).HasColumnName("Fecha_Entrada");
            entity.Property(e => e.FechaSalida).HasColumnName("Fecha_Salida");
            entity.Property(e => e.IdEmpleado).HasColumnName("ID_Empleado");
            entity.Property(e => e.IdLocalidad).HasColumnName("ID_Localidad");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.JornadaLaborals)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Jornada_L__ID_Em__6D0D32F4");

            entity.HasOne(d => d.IdLocalidadNavigation).WithMany(p => p.JornadaLaborals)
                .HasForeignKey(d => d.IdLocalidad)
                .HasConstraintName("FK__Jornada_L__ID_Lo__6E01572D");
        });

        modelBuilder.Entity<LibroFirma>(entity =>
        {
            entity.HasKey(e => e.IdLibroFirma).HasName("PK__Libro_Fi__4A04D3345C14ABB8");

            entity.ToTable("Libro_Firma");

            entity.Property(e => e.IdLibroFirma).HasColumnName("ID_Libro_Firma");
            entity.Property(e => e.IdDefuncion).HasColumnName("ID_Defuncion");
            entity.Property(e => e.Mensaje).HasMaxLength(500);
            entity.Property(e => e.NombreFirma)
                .HasMaxLength(100)
                .HasColumnName("Nombre_Firma");

            entity.HasOne(d => d.IdDefuncionNavigation).WithMany(p => p.LibroFirmas)
                .HasForeignKey(d => d.IdDefuncion)
                .HasConstraintName("FK__Libro_Fir__ID_De__70DDC3D8");
        });

        modelBuilder.Entity<Localidad>(entity =>
        {
            entity.HasKey(e => e.IdLocalidad).HasName("PK__Localida__8ACE3DA1CEF7AD1D");

            entity.ToTable("Localidad");

            entity.Property(e => e.IdLocalidad).HasColumnName("ID_Localidad");
            entity.Property(e => e.Direccion).HasMaxLength(200);
            entity.Property(e => e.IdContacto1).HasColumnName("ID_Contacto1");
            entity.Property(e => e.IdContacto2).HasColumnName("ID_Contacto2");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(9);
        });

        modelBuilder.Entity<Sala>(entity =>
        {
            entity.HasKey(e => e.IdSala).HasName("PK__Salas__2071DEA78EF6652C");

            entity.Property(e => e.IdSala).HasColumnName("ID_Sala");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");
            entity.Property(e => e.IdLocalidad).HasColumnName("ID_Localidad");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Salas)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Salas__ID_Catego__534D60F1");

            entity.HasOne(d => d.IdLocalidadNavigation).WithMany(p => p.Salas)
                .HasForeignKey(d => d.IdLocalidad)
                .HasConstraintName("FK__Salas__ID_Locali__52593CB8");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PK__Servicio__1932F5845361580F");

            entity.Property(e => e.IdServicio).HasColumnName("ID_Servicio");
            entity.Property(e => e.Costo).HasColumnType("money");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<ServiciosCategoria>(entity =>
        {
            entity.HasKey(e => new { e.IdServicio, e.IdCategoria }).HasName("PK__Servicio__591855FC25F090D0");

            entity.ToTable("Servicios_Categorias");

            entity.Property(e => e.IdServicio).HasColumnName("ID_Servicio");
            entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");
            entity.Property(e => e.Costo).HasColumnType("money");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.ServiciosCategoria)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Servicios__ID_Ca__5EBF139D");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServiciosCategoria)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Servicios__ID_Se__5DCAEF64");
        });

        modelBuilder.Entity<TipoIdentificacion>(entity =>
        {
            entity.HasKey(e => e.IdIdentificacion).HasName("PK__Tipo_Ide__2D8D9EE1C5135998");

            entity.ToTable("Tipo_Identificacion");

            entity.Property(e => e.IdIdentificacion).HasColumnName("ID_Identificacion");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
