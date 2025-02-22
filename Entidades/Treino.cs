using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Treino
    {
        public UInt64 Id { get; set; }
        [Required]
        public Char Nome { get; set; }
        [Required]
        public Programacao Programacao { get; set; }
        public UInt64 ProgramacaoId { get; set; }
        [Required]
        public List<Exercicio> Exercicios { get; set; }
        public Treino()
        {
            Exercicios = new List<Exercicio>();
        }
    }
}
