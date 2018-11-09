using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspCore_Scaffolding
{
    public partial class CrudContext : DbContext
    {
        public CrudContext()
        {
        }

        public CrudContext(DbContextOptions<CrudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CadastroDb> CadastroDb { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }

     /*   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=PBR007001-13400\\SQLEXPRESS;Initial Catalog=Crud;Integrated Security=True");
            }
        }
*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CadastroDb>(entity =>
            {
                entity.HasKey(e => e.FuncionarioId);

                entity.Property(e => e.FuncionarioId).ValueGeneratedNever();

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Departamento).HasMaxLength(50);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("idEmpresa")
                    .ValueGeneratedNever();

                entity.Property(e => e.cnpjEmpresa)
                .HasColumnName("cnpjEmpresa")
                .HasMaxLength(50);


                entity.Property(e => e.numero)
                .IsRequired()
                .HasColumnName("numero");


                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("endereco")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeEmpresa)
                    .IsRequired()
                    .HasColumnName("nomeEmpresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
