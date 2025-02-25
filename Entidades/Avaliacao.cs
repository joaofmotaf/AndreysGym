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
        [Browsable(false)]
        public UInt64 Id { get; set; }

        // Informações gerais
        [Category("1 - Informações Gerais")]
        [DisplayName("Usuário")]
        public Usuario Usuario { get; set; }

        [Browsable(false)]
        public UInt64 UsuarioId { get; set; }

        [Category("1 - Informações Gerais")]
        [DisplayName("Personal Responsável")]
        public Usuario PersonalResponsavel { get; set; }

        [Browsable(false)]
        public UInt64 PersonalResponsavelId { get; set; }

        [Category("1 - Informações Gerais")]
        [DisplayName("Data da Avaliação")]
        public DateTime DataRealizacao { get; set; }

        [Category("2 - Anamnese")]
        [DisplayName("Idade do Cliente")]
        public Int32 IdadeCliente { get; set; }

        [Category("2 - Anamnese")]
        [DisplayName("Objetivo")]
        public string Objetivo { get; set; }

        [Category("2 - Anamnese")]
        [DisplayName("Medicamentos")]
        public string Medicamentos { get; set; }

        [Category("2 - Anamnese")]
        [DisplayName("Sedentarismo?")]
        public bool Sedentarismo { get; set; }

        [Category("2 - Anamnese")]
        [DisplayName("Problemas de Saúde")]
        public string ProblemasSaude { get; set; }

        [Category("2 - Anamnese")]
        [DisplayName("Histórico Familiar de Doenças")]
        public string HistoricoDoencaFamiliar { get; set; }

        // Medidas Corporais
        [Category("3 - Composição Corporal")]
        [DisplayName("Massa Magra (kg)")]
        public decimal MassaMagra { get; set; }

        [Category("3 - Composição Corporal")]
        [DisplayName("Massa Gorda (kg)")]
        public decimal MassaGorda { get; set; }

        [Category("3 - Composição Corporal")]
        [DisplayName("Peso (kg)")]
        public decimal Peso { get; set; }

        [Category("3 - Composição Corporal")]
        [DisplayName("Altura (cm)")]
        public decimal Altura { get; set; }



        //
        // Propriedades Calculadas
        //
        // Essas propriedades não são armazenadas com métodos setters; ao invés disso,
        // são calculadas no momento em que o objeto é carregado (tanto que não são
        // carregadas no banco de dados); em decorrência disso, decidimos que seria 
        // melhor retorná-las como um String, pois não afeta o funcionamento geral
        // e ajuda a formatação no PropertyGrid.
        //
        

        [Category("3 - Composição Corporal")]
        [DisplayName("Porcentagem de Massa Magra (%)")]
        public String PorcentagemMassaMagra => (MassaMagra / (MassaMagra + MassaGorda) * 100).ToString("F2");

        [Category("3 - Composição Corporal")]
        [DisplayName("Porcentagem de Massa Gorda (%)")]
        public String PorcentagemMassaGorda => (MassaGorda / (MassaMagra + MassaGorda) * 100).ToString("F2");

        [Category("3 - Composição Corporal")]
        [DisplayName("Índice de Massa Corporal (IMC)")]
        public String IMC => (Peso * 10000 / (Altura * Altura)).ToString("F2");

        // Medidas por Região Corporal
        [Category("4.1 - Medidas - Tronco")]
        [DisplayName("Tórax Relaxado (cm)")]
        public decimal PerimetroToraxRelaxado { get; set; }

        [Category("4.1 - Medidas - Tronco")]
        [DisplayName("Cintura (cm)")]
        public decimal PerimetroCintura { get; set; }

        [Category("4.1 - Medidas - Tronco")]
        [DisplayName("Abdome (cm)")]
        public decimal PerimetroAbdome { get; set; }

        [Category("4.1 - Medidas - Tronco")]
        [DisplayName("Quadril (cm)")]
        public decimal PerimetroQuadril { get; set; }

        [Category("4.2 - Medidas - Braços")]
        [DisplayName("Braço Esquerdo Relaxado (cm)")]
        public decimal PerimetroBracoEsquerdoRelaxado { get; set; }

        [Category("4.2 - Medidas - Braços")]
        [DisplayName("Braço Esquerdo Contraído (cm)")]
        public decimal PerimetroBracoEsquerdoContraido { get; set; }

        [Category("4.2 - Medidas - Braços")]
        [DisplayName("Braço Direito Relaxado (cm)")]
        public decimal PerimetroBracoDireitoRelaxado { get; set; }

        [Category("4.2 - Medidas - Braços")]
        [DisplayName("Braço Direito Contraído (cm)")]
        public decimal PerimetroBracoDireitoContraido { get; set; }

        [Category("4.2 - Medidas - Braços")]
        [DisplayName("Antebraço Esquerdo (cm)")]
        public decimal PerimetroAntebracoEsquerdo { get; set; }

        [Category("4.2 - Medidas - Braços")]
        [DisplayName("Antebraço Direito (cm)")]
        public decimal PerimetroAntebracoDireito { get; set; }

        [Category("4.3 - Medidas - Pernas")]
        [DisplayName("Coxa Esquerda (cm)")]
        public decimal PerimetroCoxaEsquerda { get; set; }

        [Category("4.3 - Medidas - Pernas")]
        [DisplayName("Coxa Direita (cm)")]
        public decimal PerimetroCoxaDireita { get; set; }

        [Category("4.3 - Medidas - Pernas")]
        [DisplayName("Panturrilha Esquerda (cm)")]
        public decimal PerimetroPanturrilhaEsquerda { get; set; }

        [Category("4.3 - 4.2 - Medidas - Pernas")]
        [DisplayName("Panturrilha Direita (cm)")]
        public decimal PerimetroPanturrilhaDireita { get; set; }        

        public override string ToString()
        {
            return $"Avaliação {Usuario.Avaliacoes.IndexOf(this) + 1} - {DataRealizacao:d}";
        }
    }

}