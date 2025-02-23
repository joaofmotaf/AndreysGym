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
        [Required]
        public DateTime DataRealizacao { get; set; }
        [Required]
        public Int32 IdadeCliente { get; set; }
        [Required, MaxLength(64)]
        public String Objetivo { get; set; }
        [MaxLength(255)]
        public String Medicamentos { get; set; }
        [Required, MaxLength(255)]
        public String Sedentarismo { get; set; }
        [MaxLength(255)]
        public String ProblemasSaude { get; set; }
        [MaxLength(255)]
        public String HistoricoDoencaFamiliar { get; set; }
        [Required]
        public Single MassaMagra { get; set; }
        [Required]
        public Single MassaGorda { get; set; }
        [Required]
        public Single Peso { get; set; }
        [Required]
        public Single Altura { get; set; }
        [Required]
        public UInt16 PerimetroToraxRelaxado { get; set; }
        [Required]
        public UInt16 PerimetroCintura { get; set; }
        [Required]
        public UInt16 PerimetroAbdome { get; set; }
        [Required]
        public UInt16 PerimetroQuadril { get; set; }
        [Required]
        public UInt16 PerimetroBracoEsquerdoRelaxado { get; set; }
        [Required]
        public UInt16 PerimetroBracoEsquerdoContraido { get; set; }
        [Required]
        public UInt16 PerimetroBracoDireitoRelaxado { get; set; }
        [Required]
        public UInt16 PerimetroBracoDireitoContraido { get; set; }
        [Required]
        public UInt16 PerimetroAntebracoEsquerdo { get; set; }
        [Required]
        public UInt16 PerimetroAntebracoDireito { get; set; }
        [Required]
        public UInt16 PerimetroCoxaEsquerda { get; set; }
        [Required]
        public UInt16 PerimetroCoxaDireita { get; set; }
        [Required]
        public UInt16 PerimetroPanturrilhaEsquerda { get; set; }
        [Required]
        public UInt16 PerimetroPanturrilhaDireita { get; set; }
        public Single CalcularPorcentagemMassaMagra()

        {
            return MassaMagra / (MassaMagra + MassaGorda);
        }
        public Single CalcularPorcentagemMassaGorda()
        {
            return MassaGorda / (MassaMagra + MassaGorda);
        }
        public Single CalcularImc()
        {
            return Peso / (Altura * Altura);
        }
    }
}
