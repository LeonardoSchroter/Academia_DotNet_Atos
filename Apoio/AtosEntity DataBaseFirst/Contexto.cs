using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AtosEntity_DataBaseFirst;

public partial class Contexto : DbContext
{
    public Contexto()
    {
    }

    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder
        .UseSqlServer("Data Source=localhost; Initial Catalog=atosEntity2;User ID=AtosEntity2; password=AtosEntity2; language=Portuguese;Trusted_Connection=true;TrustServerCertificate=true;")
        .UseLazyLoadingProxies();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Email__3213E83FB696BC09");

            entity.ToTable("Email");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FkPessoa).HasColumnName("fk_pessoa");

            entity.HasOne(d => d.FkPessoaNavigation).WithMany(p => p.Emails)
                .HasForeignKey(d => d.FkPessoa)
                .HasConstraintName("FK__Email__fk_pessoa__267ABA7A");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pessoas__3213E83F9E334ADE");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
