using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class GrupoMuscular
    {
        public UInt64 Id { get; set; }
        [Required]
        public String Nome { get; set; }
        public Exercicio Exercicio { get; set; }
    }

}
