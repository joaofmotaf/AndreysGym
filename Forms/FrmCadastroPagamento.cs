﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AndreysGym.Entidades;
using AndreysGym.Repositories;

namespace AndreysGym.Forms
{
    public partial class FrmCadastroPagamento : Form
    {
        private static FrmCadastroPagamento _instance;
        private static Usuario _usuario;
        private static Usuario _usuario2;

        private FrmCadastroPagamento()
        {
            InitializeComponent();

            txtNome.Text = _usuario.Nome;
            txtEmail.Text = _usuario.Credencial.Email;
            txtCpf.Text = Convert.ToString(_usuario.Cpf);
            txtPlano.Text = _usuario.Plano.Nome;
            txtPeriodicidade.Text = Convert.ToString(_usuario.Plano.Periodicidade);
            txtPreco.Text = Convert.ToString(_usuario.Plano.Preco);

            mtbPagamento.Text = Convert.ToString(DateTime.Now);
        }

        public static FrmCadastroPagamento GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _usuario = usuario;
                _instance = new FrmCadastroPagamento();
            }
            return _instance;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
