using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym
{
    public class Usuario
    {
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public UInt64 Cpf { get; set; }
        public Byte CalcularIdade()
        {
            return 0;
        }
    }
}
