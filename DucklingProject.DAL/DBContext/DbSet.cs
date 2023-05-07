using System;
using System.Collections.Generic;
using DucklingProject.MODEL;
using Microsoft.EntityFrameworkCore;

namespace DucklingProject.DAL.DBContext;

public partial class DbSet : DbContext
{
    public DbSet()
    {
    }

    public DbSet(DbContextOptions<DbSet> options)
        : base(options)
    {
    }

    public virtual DbSet<TbManager> TbManagers { get; set; }

    public virtual DbSet<TbProject> TbProjects { get; set; }

    public virtual DbSet<TbStatus> TbStatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Orlando Mota\\Documents\\coisasNOVAS\\Programacao\\RepositoriosGithub\\DucklingProject\\DucklingProject.DAL\\Database\\Database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbManager>(entity =>
        {
            entity.HasKey(e => e.IdManager).HasName("PK__TB_manag__19BC3765C1AE0A7D");

            entity.ToTable("TB_manager");

            entity.Property(e => e.IdManager).HasColumnName("ID_manager");
            entity.Property(e => e.ManagerName)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("manager_name");
        });

        modelBuilder.Entity<TbProject>(entity =>
        {
            entity.HasKey(e => e.IdProject).HasName("PK__TB_proje__1231D5474188F294");

            entity.ToTable("TB_project");

            entity.Property(e => e.IdProject).HasColumnName("ID_project");
            entity.Property(e => e.DtFinish)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DT_finish");
            entity.Property(e => e.DtStart)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DT_start");
            entity.Property(e => e.IdManager).HasColumnName("ID_manager");
            entity.Property(e => e.IdStatus).HasColumnName("ID_status");
            entity.Property(e => e.ProjectDescription)
                .HasMaxLength(300)
                .IsFixedLength()
                .HasColumnName("project_description");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("project_name");

            entity.HasOne(d => d.IdManagerNavigation).WithMany(p => p.TbProjects)
                .HasForeignKey(d => d.IdManager)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_manager");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.TbProjects)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_status");
        });

        modelBuilder.Entity<TbStatus>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__TB_statu__449BD7E697CCDF00");

            entity.ToTable("TB_status");

            entity.Property(e => e.IdStatus).HasColumnName("ID_status");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
