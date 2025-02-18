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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionParams);
        }
    }
}
