using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym
{
    public class Avaliacao
    {
        public Usuario PersonalResponsavel { get; set; }
        public DateTime DataRealizacao { get; set; }
        public Int32 IdadeCliente { get; set; }
        public String Objetivo { get; set; }
        public String Medicamentos { get; set; }
        public String Sedentarismo { get; set; }
        public String ProblemasSaude { get; set; }
        public String HistoricoDoencaFamiliar { get; set; }
        public Single MassaMagra { get; set; }
        public Single MassaGorda { get; set; }
        public Single Peso { get; set; }
        public Single Altura { get; set; }
        public UInt16 PerimetroToraxRelaxado { get; set; }
        public UInt16 PerimetroCintura { get; set; }
        public UInt16 PerimetroAbdome { get; set; }
        public UInt16 PerimetroQuadril { get; set; }
        public UInt16 PerimetroBracoEsquerdoRelaxado { get; set; }
        public UInt16 PerimetroBracoEsquerdoContraido { get; set; }
        public UInt16 PerimetroBracoDireitoRelaxado { get; set; }
        public UInt16 PerimetroBracoDireitoContraido { get; set; }
        public UInt16 PerimetroAntebracoEsquerdo { get; set; }
        public UInt16 PerimetroAntebracoDireito { get; set; }
        public UInt16 PerimetroCoxaEsquerda { get; set; }
        public UInt16 PerimetroCoxaDireita { get; set; }
        public UInt16 PerimetroPanturrilhaEsquerda { get; set; }
        public UInt16 PerimetroPanturrilhaDireita { get; set; }
        public Single CalcularPorcentagemMassaMagra()
        {
            return (MassaMagra) / (MassaMagra + MassaGorda);
        }
        public Single CalcularPorcentagemMassaGorda()
        {
            return (MassaGorda) / (MassaMagra + MassaGorda);
        }
        public Single CalcularImc()
        {
            return Peso / (Altura * Altura);
        }
    }
}
