using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GlobeCol.Web
{
    public partial class GlobeColDbContext : DbContext
    {
        public GlobeColDbContext()
        {
        }

        public GlobeColDbContext(DbContextOptions<GlobeColDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Certificaciones> Certificaciones { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<EmpleadoCertificaciones> EmpleadoCertificaciones { get; set; }
        public virtual DbSet<EmpleadoNovedades> EmpleadoNovedades { get; set; }
        public virtual DbSet<Gerente> Gerente { get; set; }
        public virtual DbSet<MallaHoraria> MallaHoraria { get; set; }
        public virtual DbSet<Novedades> Novedades { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("database=globecol;server=localhost;port=3306;user id=root;password=Sam10");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.IdAdministrador)
                    .HasName("PRIMARY");

                entity.ToTable("administrador");

                entity.Property(e => e.IdAdministrador)
                    .HasColumnName("id_administrador")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Certificaciones>(entity =>
            {
                entity.HasKey(e => e.IdCertificacion)
                    .HasName("PRIMARY");

                entity.ToTable("certificaciones");

                entity.Property(e => e.IdCertificacion)
                    .HasColumnName("id_certificacion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoSolicitud)
                    .HasColumnName("tipo_solicitud")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PRIMARY");

                entity.ToTable("empleado");

                entity.HasIndex(e => e.CodHorario)
                    .HasName("cod_horario");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnName("id_empleado")
                    .HasColumnType("int(6)");

                entity.Property(e => e.CodHorario)
                    .HasColumnName("cod_horario")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.CodHorarioNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.CodHorario)
                    .HasConstraintName("empleado_ibfk_1");
            });

            modelBuilder.Entity<EmpleadoCertificaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("empleado_certificaciones");

                entity.HasIndex(e => e.IdCertificacion)
                    .HasName("id_certificacion");

                entity.HasIndex(e => e.IdEmpleado)
                    .HasName("id_empleado");

                entity.HasIndex(e => e.IdGerente)
                    .HasName("id_gerente");

                entity.Property(e => e.IdCertificacion)
                    .HasColumnName("id_certificacion")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnName("id_empleado")
                    .HasColumnType("int(6)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdGerente)
                    .HasColumnName("id_gerente")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdCertificacionNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCertificacion)
                    .HasConstraintName("empleado_certificaciones_ibfk_1");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("empleado_certificaciones_ibfk_2");

                entity.HasOne(d => d.IdGerenteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdGerente)
                    .HasConstraintName("empleado_certificaciones_ibfk_3");
            });

            modelBuilder.Entity<EmpleadoNovedades>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("empleado_novedades");

                entity.HasIndex(e => e.IdAdministrador)
                    .HasName("id_administrador");

                entity.HasIndex(e => e.IdEmpleado)
                    .HasName("id_empleado");

                entity.HasIndex(e => e.IdNovedad)
                    .HasName("id_novedad");

                entity.Property(e => e.IdAdministrador)
                    .HasColumnName("id_administrador")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnName("id_empleado")
                    .HasColumnType("int(6)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdNovedad)
                    .HasColumnName("id_novedad")
                    .HasColumnType("int(6)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdAdministradorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdAdministrador)
                    .HasConstraintName("empleado_novedades_ibfk_3");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("empleado_novedades_ibfk_1");

                entity.HasOne(d => d.IdNovedadNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdNovedad)
                    .HasConstraintName("empleado_novedades_ibfk_2");
            });

            modelBuilder.Entity<Gerente>(entity =>
            {
                entity.HasKey(e => e.IdGerente)
                    .HasName("PRIMARY");

                entity.ToTable("gerente");

                entity.Property(e => e.IdGerente)
                    .HasColumnName("id_gerente")
                    .HasColumnType("int(8)");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RimerNombre)
                    .HasColumnName("rimer_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<MallaHoraria>(entity =>
            {
                entity.HasKey(e => e.CodHorario)
                    .HasName("PRIMARY");

                entity.ToTable("malla_horaria");

                entity.Property(e => e.CodHorario)
                    .HasColumnName("cod_horario")
                    .HasColumnType("int(5)");

                entity.Property(e => e.HorarioJornada)
                    .HasColumnName("horario_jornada")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Novedades>(entity =>
            {
                entity.HasKey(e => e.IdNovedad)
                    .HasName("PRIMARY");

                entity.ToTable("novedades");

                entity.Property(e => e.IdNovedad)
                    .HasColumnName("id_novedad")
                    .HasColumnType("int(6)");

                entity.Property(e => e.TipoNovedad)
                    .HasColumnName("tipo_novedad")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.CodRol)
                    .HasName("PRIMARY");

                entity.ToTable("rol");

                entity.Property(e => e.CodRol)
                    .HasColumnName("cod_rol")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreRol)
                    .HasColumnName("nombre_rol")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.CodRol)
                    .HasName("cod_rol");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodRol)
                    .HasColumnName("cod_rol")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdAdministrador)
                    .HasColumnName("id_administrador")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RimerNombre)
                    .HasColumnName("rimer_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.CodRolNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.CodRol)
                    .HasConstraintName("usuario_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
