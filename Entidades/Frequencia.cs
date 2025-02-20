using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Frequencia
    {
        public UInt64 Id { get; set; }
        [Required]
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        [Required]
        public Usuario Usuario { get; set; }
    }
}
