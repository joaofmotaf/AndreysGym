using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Exercicio
    {
        public UInt64 Id { get; set; }
        [Required]
        public UInt16 QuantidadeSeries { get; set; }
        [Required]
        public UInt16 QuantidadeRepeticoes { get; set; }
        [Required]
        public List<GrupoMuscular> GruposMusculares { get; set; }
        public Exercicio()
        {
            GruposMusculares = new List<GrupoMuscular>();
        }
    }
}
