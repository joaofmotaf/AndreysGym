using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AndreysGym.Entidades
{
    [Index(nameof(Cpf), IsUnique = true)]
    public class Usuario
    {
        public UInt64 Id { get; set; }
        [Required, MaxLength(255)]
        public string Nome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public ulong Cpf { get; set; }
        [Required]
        public Credencial Credencial { get; set; }
        [Required]
        public List<Frequencia> Frequencias { get; set; }
        [Required]
        public List<Avaliacao> Avaliacoes { get; set; }
        [Required]
        public List<Pagamento> Pagamentos { get; set; }
        [Required]
        public List<Programacao> Programacoes { get; set; }
        public int CalcularIdade()
        {
            int idade = DateTime.Today.Year - DataNascimento.Year;
            return DataNascimento.Date > DateTime.Today.AddYears(-idade) ? --idade : idade;
        }
        public Usuario()
        {
            Frequencias = new List<Frequencia>();
            Avaliacoes = new List<Avaliacao>();
            Pagamentos = new List<Pagamento>();
            Programacoes = new List<Programacao>();
        }

    }
}
