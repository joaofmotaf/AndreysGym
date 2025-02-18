using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Avaliacao
    {
        public Usuario PersonalResponsavel { get; set; }
        public DateTime DataRealizacao { get; set; }
        public int IdadeCliente { get; set; }
        public string Objetivo { get; set; }
        public string Medicamentos { get; set; }
        public string Sedentarismo { get; set; }
        public string ProblemasSaude { get; set; }
        public string HistoricoDoencaFamiliar { get; set; }
        public float MassaMagra { get; set; }
        public float MassaGorda { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public ushort PerimetroToraxRelaxado { get; set; }
        public ushort PerimetroCintura { get; set; }
        public ushort PerimetroAbdome { get; set; }
        public ushort PerimetroQuadril { get; set; }
        public ushort PerimetroBracoEsquerdoRelaxado { get; set; }
        public ushort PerimetroBracoEsquerdoContraido { get; set; }
        public ushort PerimetroBracoDireitoRelaxado { get; set; }
        public ushort PerimetroBracoDireitoContraido { get; set; }
        public ushort PerimetroAntebracoEsquerdo { get; set; }
        public ushort PerimetroAntebracoDireito { get; set; }
        public ushort PerimetroCoxaEsquerda { get; set; }
        public ushort PerimetroCoxaDireita { get; set; }
        public ushort PerimetroPanturrilhaEsquerda { get; set; }
        public ushort PerimetroPanturrilhaDireita { get; set; }
        public float CalcularPorcentagemMassaMagra()
        {
            return MassaMagra / (MassaMagra + MassaGorda);
        }
        public float CalcularPorcentagemMassaGorda()
        {
            return MassaGorda / (MassaMagra + MassaGorda);
        }
        public float CalcularImc()
        {
            return Peso / (Altura * Altura);
        }
    }
}
