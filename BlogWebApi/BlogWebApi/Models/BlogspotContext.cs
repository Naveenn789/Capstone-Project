using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlogWebApi.Models
{
    public partial class BlogspotContext : DbContext
    {
        public BlogspotContext()
        {
        }

        public BlogspotContext(DbContextOptions<BlogspotContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminInfo> AdminInfos { get; set; } = null!;
        public virtual DbSet<BlogInfo> BlogInfos { get; set; } = null!;
        public virtual DbSet<EmpInfo> EmpInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=NAVEEN-BOOK-8C9;database=Blogspot;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AdminInfo");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<BlogInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BlogInfo");

                entity.Property(e => e.BlogUrl).HasMaxLength(50);

                entity.Property(e => e.DateOfCreation).HasColumnType("datetime");

                entity.Property(e => e.EmpEmailId).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.EmpEmail)
                    .WithMany()
                    .HasForeignKey(d => d.EmpEmailId)
                    .HasConstraintName("FK__BlogInfo__EmpEma__398D8EEE");
            });

            modelBuilder.Entity<EmpInfo>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("PK__EmpInfo__7ED91ACFF284D3B7");

                entity.ToTable("EmpInfo");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.DatOfJoining).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
