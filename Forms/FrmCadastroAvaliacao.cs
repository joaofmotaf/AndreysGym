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
        }

        public static FrmCadastroAvaliacao GetInstancia()
        {
            if (_instance == null || _instance.IsDisposed)
            {
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
                Altura = nudAltura.Value
            };
        }

        private void pnlCadAvaliacao_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}