﻿using AndreysGym.Entidades;
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
    public partial class FrmCadastroAvaliacao : Form
    {
        private static Usuario _usuarioAvaliado;
        private static Usuario _personalResponsavel;

        private static FrmCadastroAvaliacao _instance;

        private FrmCadastroAvaliacao()
        {
            InitializeComponent();
            txtPersonal.Text = _personalResponsavel.Nome;
            dtpDataRealizacao.Value = DateTime.Today;
            nudIdade.Value = _usuarioAvaliado.CalcularIdade();
        }


        public static FrmCadastroAvaliacao GetInstance(Usuario usuarioAvaliado, Usuario personalResponsavel)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _personalResponsavel = personalResponsavel;
                _usuarioAvaliado = usuarioAvaliado;
                _instance = new FrmCadastroAvaliacao();
            }
            return _instance;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CadastroAvaliacao_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Avaliacao avaliacao = new Avaliacao
            {
                DataRealizacao = DateTime.Today,
                Objetivo = txtObjetivo.Text,
                Medicamentos = txtMedicamentos.Text,
                ProblemasSaude = txtProblemasSaude.Text,
                HistoricoDoencaFamiliar = txtHistorico.Text,
                Sedentarismo = chkSedentarismo.Checked,
                MassaMagra = nudMassaMagra.Value,
                MassaGorda = nudMassaGorda.Value,
                Peso = nudPeso.Value,
                Altura = nudAltura.Value,
                Usuario = _usuarioAvaliado,
                IdadeCliente = (Int32)nudIdade.Value,
                PersonalResponsavel = _personalResponsavel,
                PerimetroPanturrilhaDireita = nudPerimetroPanturrilhaDir.Value,
                PerimetroPanturrilhaEsquerda = nudPerimetroPanturrilhaEsq.Value,
                PerimetroBracoDireitoRelaxado = nudPerimetroBracoDirRelaxado.Value,
                PerimetroBracoEsquerdoRelaxado = nudPerimetroBracoEsqRelaxado.Value,
                PerimetroBracoDireitoContraido = nudPerimetroBracoDirContraido.Value,
                PerimetroBracoEsquerdoContraido = nudPerimetroBracoEsqContraido.Value,
                PerimetroAntebracoDireito = nudPerimetroAntebracoDir.Value,
                PerimetroAntebracoEsquerdo = nudPerimetroAntebracoEsq.Value,
                PerimetroCoxaDireita = nudPerimetroCoxaDir.Value,
                PerimetroCoxaEsquerda = nudPerimetroCoxaEsq.Value,
                PerimetroAbdome = nudPerimetroAbdome.Value,
                PerimetroCintura = nudPerimetroCintura.Value,
                PerimetroQuadril = nudPerimetroQuadril.Value,
                PerimetroToraxRelaxado = nudPerimetroToraxRelaxado.Value
            };
            FrmAvaliacoes.GetInstance(_personalResponsavel, _usuarioAvaliado).SalvarAvaliacao(avaliacao);
            Close();
        }

        private void pnlCadAvaliacao_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void txtObjetivo_TextChanged(object sender, EventArgs e)
        {
            VerificarDados();
        }

        private void VerificarDados()
        {
            btnSalvar.Enabled = (txtObjetivo.Text != String.Empty &&
                txtMedicamentos.Text != String.Empty &&
                txtHistorico.Text != String.Empty &&
                txtProblemasSaude.Text != String.Empty &&
                nudMassaMagra.Value != 0 &&
                nudMassaGorda.Value != 0 &&
                nudAltura.Value != 0);
        }

        private void txtMedicamentos_TextChanged(object sender, EventArgs e)
        {
            VerificarDados();
        }

        private void txtProblemasSaude_TextChanged(object sender, EventArgs e)
        {
            VerificarDados();
        }

        private void txtHistorico_TextChanged(object sender, EventArgs e)
        {
            VerificarDados();
        }

        private void nudMassaMagra_ValueChanged(object sender, EventArgs e)
        {
            nudPeso.Value = nudMassaGorda.Value + nudMassaMagra.Value;
            VerificarDados();
        }

        private void nudMassaGorda_ValueChanged(object sender, EventArgs e)
        {
            nudPeso.Value = nudMassaGorda.Value + nudMassaMagra.Value;
            VerificarDados();
        }

        private void nudAltura_ValueChanged(object sender, EventArgs e)
        {
            VerificarDados();
        }
    }
}