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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            AtualizarBotaoCadastro();
        }

        private void AtualizarBotaoCadastro()
        {
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            AtualizarBotaoCadastro();
        }

        private void mskCpf_TextChanged(object sender, EventArgs e)
        {
            AtualizarBotaoCadastro();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            AtualizarBotaoCadastro();
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            AtualizarBotaoCadastro();
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
            try
            {
                UsuarioRepository.Save(usuario);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
