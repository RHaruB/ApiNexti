using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiNexti.Models;

public partial class NextiContext : DbContext
{
    public NextiContext()
    {
    }

    public NextiContext(DbContextOptions<NextiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Informacion> Informacions { get; set; }

    public virtual DbSet<LogEvento> LogEventos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3214EC277638E08A");

            entity.ToTable("Cliente");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido).HasMaxLength(255);
            entity.Property(e => e.Cedula).HasMaxLength(20);
            entity.Property(e => e.Correo).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Evento__3214EC276E71845C");

            entity.ToTable("Evento");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEvento).HasColumnType("date");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.LugarEvento).HasMaxLength(255);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Informacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Informacion");

            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion).IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogEvento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LogEvent__3214EC276A716710");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Accion).HasMaxLength(50);
            entity.Property(e => e.FechaAccion).HasColumnType("datetime");
            entity.Property(e => e.Idevento).HasColumnName("IDEvento");
            entity.Property(e => e.Usuario).HasMaxLength(100);

            entity.HasOne(d => d.IdeventoNavigation).WithMany(p => p.LogEventos)
                .HasForeignKey(d => d.Idevento)
                .HasConstraintName("FK_LogEventos_Evento");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Persona");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
