using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{
    public class Avaliacao
    {
        [Required]
        public Usuario Usuario { get; set; }
        public UInt64 UsuarioId { get; set; }

        public UInt64 Id { get; set; }
        [Required]
        public Usuario PersonalResponsavel { get; set; }
        public UInt64 PersonalResponsavelId { get; set; }
        [Required]
        public DateTime DataRealizacao { get; set; }
        [Required]
        public Int32 IdadeCliente { get; set; }
        [Required, MaxLength(64)]
        public String Objetivo { get; set; }
        [MaxLength(255)]
        public String Medicamentos { get; set; }
        [Required, MaxLength(255)]
        public Boolean Sedentarismo { get; set; }
        [MaxLength(255)]
        public String ProblemasSaude { get; set; }
        [MaxLength(255)]
        public String HistoricoDoencaFamiliar { get; set; }
        [Required]
        public Decimal MassaMagra { get; set; }
        [Required]
        public Decimal MassaGorda { get; set; }
        [Required]
        public Decimal Peso { get; set; }
        [Required]
        public Decimal Altura { get; set; }
        [Required]
        public Decimal PerimetroToraxRelaxado { get; set; }
        [Required]
        public Decimal PerimetroCintura { get; set; }
        [Required]
        public Decimal PerimetroAbdome { get; set; }
        [Required]
        public Decimal PerimetroQuadril { get; set; }
        [Required]
        public Decimal PerimetroBracoEsquerdoRelaxado { get; set; }
        [Required]
        public Decimal PerimetroBracoEsquerdoContraido { get; set; }
        [Required]
        public Decimal PerimetroBracoDireitoRelaxado { get; set; }
        [Required]
        public Decimal PerimetroBracoDireitoContraido { get; set; }
        [Required]
        public Decimal PerimetroAntebracoEsquerdo { get; set; }
        [Required]
        public Decimal PerimetroAntebracoDireito { get; set; }
        [Required]
        public Decimal PerimetroCoxaEsquerda { get; set; }
        [Required]
        public Decimal PerimetroCoxaDireita { get; set; }
        [Required]
        public Decimal PerimetroPanturrilhaEsquerda { get; set; }
        [Required]
        public Decimal PerimetroPanturrilhaDireita { get; set; }
        public Decimal CalcularPorcentagemMassaMagra()

        {
            return MassaMagra / (MassaMagra + MassaGorda);
        }
        public Decimal CalcularPorcentagemMassaGorda()
        {
            return MassaGorda / (MassaMagra + MassaGorda);
        }
        public Decimal CalcularImc()
        {
            return Peso / (Altura * Altura);
        }
    }
}
