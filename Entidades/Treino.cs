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
    }
}
