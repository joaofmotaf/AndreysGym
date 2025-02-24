using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Entidades
{

    public class Avaliacao
    {
        // Identificação
        [Browsable(false)]
        public UInt64 Id { get; set; }

        [Category("Identificação")]
        [DisplayName("Usuário")]
        public Usuario Usuario { get; set; }

        [Category("Identificação")]
        [DisplayName("ID do Usuário")]
        [Browsable(false)]
        public UInt64 UsuarioId { get; set; }

        [Category("Identificação")]
        [DisplayName("Personal Responsável")]
        public Usuario PersonalResponsavel { get; set; }

        [Category("Identificação")]
        [DisplayName("ID do Personal Responsável")]
        [Browsable(false)]
        public UInt64 PersonalResponsavelId { get; set; }

        // Informações gerais
        [Category("Informações Gerais")]
        [DisplayName("Data da Avaliação")]
        public DateTime DataRealizacao { get; set; }

        [Category("Informações Gerais")]
        [DisplayName("Idade do Cliente")]
        public Int32 IdadeCliente { get; set; }

        [Category("Informações Gerais")]
        [DisplayName("Objetivo")]
        public string Objetivo { get; set; }

        [Category("Informações Gerais")]
        [DisplayName("Medicamentos")]
        public string Medicamentos { get; set; }

        [Category("Informações Gerais")]
        [DisplayName("Sedentarismo?")]
        public bool Sedentarismo { get; set; }

        [Category("Histórico de Saúde")]
        [DisplayName("Problemas de Saúde")]
        public string ProblemasSaude { get; set; }

        [Category("Histórico de Saúde")]
        [DisplayName("Histórico Familiar de Doenças")]
        public string HistoricoDoencaFamiliar { get; set; }

        // Medidas Corporais
        [Category("Composição Corporal")]
        [DisplayName("Massa Magra (kg)")]
        public decimal MassaMagra { get; set; }

        [Category("Composição Corporal")]
        [DisplayName("Massa Gorda (kg)")]
        public decimal MassaGorda { get; set; }

        [Category("Composição Corporal")]
        [DisplayName("Peso (kg)")]
        public decimal Peso { get; set; }

        [Category("Composição Corporal")]
        [DisplayName("Altura (cm)")]
        public decimal Altura { get; set; }

        // Medidas por Região Corporal
        [Category("Medidas - Tronco")]
        [DisplayName("Tórax Relaxado (cm)")]
        public decimal PerimetroToraxRelaxado { get; set; }

        [Category("Medidas - Tronco")]
        [DisplayName("Cintura (cm)")]
        public decimal PerimetroCintura { get; set; }

        [Category("Medidas - Tronco")]
        [DisplayName("Abdome (cm)")]
        public decimal PerimetroAbdome { get; set; }

        [Category("Medidas - Tronco")]
        [DisplayName("Quadril (cm)")]
        public decimal PerimetroQuadril { get; set; }

        [Category("Medidas - Braços")]
        [DisplayName("Braço Esquerdo Relaxado (cm)")]
        public decimal PerimetroBracoEsquerdoRelaxado { get; set; }

        [Category("Medidas - Braços")]
        [DisplayName("Braço Esquerdo Contraído (cm)")]
        public decimal PerimetroBracoEsquerdoContraido { get; set; }

        [Category("Medidas - Braços")]
        [DisplayName("Braço Direito Relaxado (cm)")]
        public decimal PerimetroBracoDireitoRelaxado { get; set; }

        [Category("Medidas - Braços")]
        [DisplayName("Braço Direito Contraído (cm)")]
        public decimal PerimetroBracoDireitoContraido { get; set; }

        [Category("Medidas - Braços")]
        [DisplayName("Antebraço Esquerdo (cm)")]
        public decimal PerimetroAntebracoEsquerdo { get; set; }

        [Category("Medidas - Braços")]
        [DisplayName("Antebraço Direito (cm)")]
        public decimal PerimetroAntebracoDireito { get; set; }

        [Category("Medidas - Pernas")]
        [DisplayName("Coxa Esquerda (cm)")]
        public decimal PerimetroCoxaEsquerda { get; set; }

        [Category("Medidas - Pernas")]
        [DisplayName("Coxa Direita (cm)")]
        public decimal PerimetroCoxaDireita { get; set; }

        [Category("Medidas - Pernas")]
        [DisplayName("Panturrilha Esquerda (cm)")]
        public decimal PerimetroPanturrilhaEsquerda { get; set; }

        [Category("Medidas - Pernas")]
        [DisplayName("Panturrilha Direita (cm)")]
        public decimal PerimetroPanturrilhaDireita { get; set; }

        // Propriedades Calculadas
        [Category("Indicadores")]
        [DisplayName("Porcentagem de Massa Magra (%)")]
        public decimal PorcentagemMassaMagra => MassaMagra / (MassaMagra + MassaGorda) * 100;

        [Category("Indicadores")]
        [DisplayName("Porcentagem de Massa Gorda (%)")]
        public decimal PorcentagemMassaGorda => MassaGorda / (MassaMagra + MassaGorda) * 100;

        [Category("Indicadores")]
        [DisplayName("Índice de Massa Corporal (IMC)")]
        public decimal IMC => Peso * 10000 / (Altura * Altura);
    }

}