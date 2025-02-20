
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Pagamento
    {
        public UInt64 Id { get; set; }
        [Required]
        public DateTime DataPagamento { get; set; }
        public Boolean Pago { get; set; }
        [Required]
        public Usuario Usuario { get; set; }
        public UInt64 UsuarioId { get; set; }
        [Required]
        public Plano Plano { get; set; }
        public UInt64 PlanoId { get; set; }
    }
}
