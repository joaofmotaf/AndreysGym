using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Plano
    {
        [Required]
        public Decimal Preco { get; set; }
        [Required]
        public Byte QuantidadeDias { get; set; }
        [Required]
        public List<Pagamento> Pagamentos { get; set; }
        public Plano()
        {
            Pagamentos = new List<Pagamento>();
        }
    }
}
