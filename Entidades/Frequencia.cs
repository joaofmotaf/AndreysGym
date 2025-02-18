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
        [Required]
        public DateTime Entrada { get; set; }
        [Required]
        public DateTime Saida { get; set; }
    }
}
