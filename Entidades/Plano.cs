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
        public String Nome { get; set; }
        public  Periodicidade Periodicidade {get;set; }
        public UInt64 Id { get; set; }
        [Required]
        public Decimal Preco { get; set; }
        [Required]
        public Byte QuantidadeDias { get; set; }
        [Required]
        public List<Pagamento> Pagamentos { get; set; }
        public Boolean Ativo { get; set; }
        public Plano()
        {
            Pagamentos = new List<Pagamento>();
        }
        public override string ToString()
        {
            return $"{Nome} - {QuantidadeDias} dias - {Preco:C} - {Periodicidade.ToString()}" + (Ativo ? null : " (Desativado)");
        }
    }
}
