using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AndreysGym.Entidades;

namespace AndreysGym.Repositories
{
    public class Repository : DbContext
    {
        private static readonly String _connectionParams =
            @"server=127.0.0.1;uid=root;pwd=;database=AndreysGym;";
        public Repository() => Database.EnsureCreated();
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Programacao> Programacoes { get; set; }
        public DbSet<Frequencia> Frequencias { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionParams);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Avaliacao>()
        .HasOne(a => a.Usuario)
        .WithMany()
        .HasForeignKey(a => a.UsuarioId)
        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Avaliacao>()
                   .HasOne(a => a.PersonalResponsavel)
                   .WithMany()
                   .HasForeignKey(a => a.PersonalResponsavelId)
                   .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Usuario>()
        .HasOne(u => u.TreinoAtual)
        .WithMany()
        .HasForeignKey(u => u.TreinoAtualId)
        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Usuario>()
        .HasOne(u => u.Plano)
        .WithMany()
        .HasForeignKey(u => u.PlanoId)
        .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
