using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Pagamento
    {
        public DateTime DataPagamento { get; set; }
        public Boolean Pago { get; set; }
        public Usuario Usuario { get; set; }
        public Plano Plano { get; set; }
    }
}
