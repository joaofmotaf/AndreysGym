using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym
{
    public class Usuario
    {
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public UInt64 Cpf { get; set; }
        public Credencial Credencial { get; set; }
        public List<Frequencia> Frequencias { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
        public Int32 CalcularIdade()
        {
            Int32 idade = DateTime.Today.Year - DataNascimento.Year;
            return (DataNascimento.Date > DateTime.Today.AddYears(-idade) ? --idade : idade);
        }
        public Usuario()
        {
            Frequencias = new List<Frequencia>();
            Avaliacoes = new List<Avaliacao>();
        }
    }
}
