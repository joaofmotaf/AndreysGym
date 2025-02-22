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
    public partial class FrmCadastro : Form
    {
        private static FrmCadastro _instance;
        private FrmCadastro()
        {
            InitializeComponent();
            datNascimento.MaxDate = DateTime.Now;
        }
        public static FrmCadastro GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmCadastro();
            }
            return _instance;
        }

        private void AtualizarJanela()
        {
            lblAviso.Hide();
            if (txtNome.Text != String.Empty &&
                txtEmail.Text != String.Empty &&
                mskCpf.Text != String.Empty &&
                txtSenha.Text != String.Empty &&
                txtSenha.Text == txtConfirmarSenha.Text &&
                mskCpf.Text.Length == 11)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Nome = txtNome.Text,
                DataNascimento = datNascimento.Value,
                Cpf = Convert.ToUInt64(mskCpf.Text),
                Credencial = new Credencial
                {
                    Email = txtEmail.Text,
                    Senha = txtSenha.Text,
                    Admin = chkAdmin.Checked
                }
            };
            txtNome.Clear();
            datNascimento.Value = DateTime.Today;
            mskCpf.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            chkAdmin.Checked = false;
            try
            {
                UsuarioRepository.Save(usuario);
                lblAviso.Text = "Cadastro efetuado com sucesso";
                lblAviso.ForeColor = Color.Green;
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException exception)
            {
                lblAviso.Text = "Email e/ou CPF já cadastrado";
                lblAviso.ForeColor = Color.Red;
            }
            lblAviso.Show();
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
    }
}
