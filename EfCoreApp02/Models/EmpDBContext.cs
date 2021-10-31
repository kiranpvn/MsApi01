using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EfCoreApp02.Models
{
    public partial class EmpDBContext : DbContext
    {
        public EmpDBContext()
        {
        }

        public EmpDBContext(DbContextOptions<EmpDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblEmployee> TblEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-DM30GHJ;database=EmpDB;Persist Security Info=True;User ID=sa;Password=welcome");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tblEmployees");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Job)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
