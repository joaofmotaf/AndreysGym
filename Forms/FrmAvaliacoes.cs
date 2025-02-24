using AndreysGym.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndreysGym.Forms
{
    public partial class FrmAvaliacoes: Form
    {
        private static FrmAvaliacoes _instance;
        private FrmAvaliacoes()
        {
            InitializeComponent();
            Avaliacao avaliacao = new Avaliacao
            {
                UsuarioId = 1, // Supondo que este ID seja válido no banco de dados
                PersonalResponsavelId = 2, // Supondo que este ID seja válido no banco de dados
                Id = 1001, // ID fictício para a avaliação
                DataRealizacao = DateTime.Now,
                IdadeCliente = 25,
                Objetivo = "Ganhar massa muscular",
                Medicamentos = "Nenhum",
                Sedentarismo = false,
                ProblemasSaude = "Nenhum",
                HistoricoDoencaFamiliar = "Hipertensão",
                MassaMagra = 65.4m,
                MassaGorda = 12.6m,
                Peso = 78m,
                Altura = 175m,
                PerimetroToraxRelaxado = 100,
                PerimetroCintura = 85,
                PerimetroAbdome = 90,
                PerimetroQuadril = 97,
                PerimetroBracoEsquerdoRelaxado = 34,
                PerimetroBracoEsquerdoContraido = 36,
                PerimetroBracoDireitoRelaxado = 35,
                PerimetroBracoDireitoContraido = 37,
                PerimetroAntebracoEsquerdo = 29,
                PerimetroAntebracoDireito = 30,
                PerimetroCoxaEsquerda = 55,
                PerimetroCoxaDireita = 56,
                PerimetroPanturrilhaEsquerda = 38,
                PerimetroPanturrilhaDireita = 39
            };
            propertyGrid1.SelectedObject = avaliacao;
        }
        public static FrmAvaliacoes GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmAvaliacoes();
            }
            return _instance;
        }
    }
}
