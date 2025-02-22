using System;
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
    public partial class FrmPerfil : Form
    {
        private static FrmPerfil _instance;
        private static Boolean _acessoAdmin;
        private static Usuario _usuario;
        private FrmPerfil()
        {
            InitializeComponent();
            txtNome.Text = _usuario.Nome;
            txtEmail.Text = _usuario.Credencial.Email;
            chkAdmin.Checked = _usuario.Credencial.Admin;
            txtNascimento.Text = _usuario.DataNascimento.ToString("d");
            mskCpf.Text = _usuario.Cpf.ToString("000.000.000-00");

            btnSalvar.Visible = _acessoAdmin;
            txtNome.ReadOnly = !_acessoAdmin;
            txtEmail.ReadOnly = !_acessoAdmin;
            chkAdmin.Enabled = _acessoAdmin;
            lblSenha.Visible = _acessoAdmin;
            txtSenha.Visible = _acessoAdmin;
            lblConfirmarSenha.Visible = _acessoAdmin;
            txtConfirmarSenha.Visible = _acessoAdmin;
        }
        public static FrmPerfil GetInstance(Usuario usuario, Boolean acessoAdmin)
        {
            _acessoAdmin = acessoAdmin;
            _usuario = usuario;
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmPerfil();
            }
            return _instance;
        }
        public static FrmPerfil GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmPerfil();
            }
            return _instance;
        }

        private void AtualizarJanela()
        {
            if (txtNome.Text != String.Empty &&
                txtEmail.Text != String.Empty &&
                mskCpf.Text != String.Empty &&
                txtSenha.Text == txtConfirmarSenha.Text &&
                mskCpf.Text.Length == 11)
            {
                btnSalvar.Enabled = _acessoAdmin;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            AtualizarJanela();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            AtualizarJanela();
        }

        private void mskCpf_TextChanged(object sender, EventArgs e)
        {
            AtualizarJanela();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            AtualizarJanela();
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            AtualizarJanela();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            AtualizarJanela();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            AtualizarJanela();
        }

        private void mskCpf_KeyDown(object sender, KeyEventArgs e)
        {
            AtualizarJanela();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            AtualizarJanela();
        }

        private void txtConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            AtualizarJanela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _usuario.Nome = txtNome.Text;
            _usuario.Credencial.Email = txtEmail.Text;
            _usuario.Credencial.Senha = txtSenha.Text;
            _usuario.Credencial.Admin = chkAdmin.Checked;
            UsuarioRepository.Save(_usuario);
            Close();
        }
    }
}
