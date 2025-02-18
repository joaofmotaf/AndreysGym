using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Usuario
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public ulong Cpf { get; set; }
        public Credencial Credencial { get; set; }
        public List<Frequencia> Frequencias { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
        public int CalcularIdade()
        {
            int idade = DateTime.Today.Year - DataNascimento.Year;
            return DataNascimento.Date > DateTime.Today.AddYears(-idade) ? --idade : idade;
        }
        public Usuario()
        {
            Frequencias = new List<Frequencia>();
            Avaliacoes = new List<Avaliacao>();
        }
    }
}
