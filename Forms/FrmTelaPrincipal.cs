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

namespace AndreysGym.Forms
{
    public partial class FrmPrincipal : Form
    {
        private static Usuario _usuario { get; set; }
        private FrmPrincipal()
        {
            InitializeComponent();

            if (_usuario.Credencial.Admin)
            {
                //Habilitado
                mnuPrincipalCliente.Enabled = false;
                mnuPrincipalAdmnistrador.Enabled = true;
                mnuTelaPrincipalArquivoSairDoPrograma.Enabled = true;
                //Vísivel
                mnuPrincipalCliente.Visible = false;
                mnuPrincipalAdmnistrador.Visible = true;
                mnuTelaPrincipalArquivoSairDoPrograma.Visible = true;
            }
            else
            {
                //Habilitado
                mnuPrincipalCliente.Enabled = true;
                mnuPrincipalAdmnistrador.Enabled = false;
                mnuTelaPrincipalArquivoSairDoPrograma.Enabled = false;
                //Vísivel
                mnuPrincipalCliente.Visible = true;
                mnuPrincipalAdmnistrador.Visible = false;
                mnuTelaPrincipalArquivoSairDoPrograma.Visible = false;
            }
        }
        private static FrmPrincipal _instance;
        public static FrmPrincipal GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _usuario = usuario;
                _instance = new FrmPrincipal();
            }
            return _instance;
        }
        public static FrmPrincipal GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmPrincipal();
            }
            return _instance;
        }

        private void FrmTelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin.GetInstance().Show();
        }

        private void mnuPrincipalAdmnistradorCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro.GetInstance().MdiParent = this;
            FrmCadastro.GetInstance().WindowState = FormWindowState.Maximized;
            FrmCadastro.GetInstance().Show();
        }



        private void registrarFrequênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroFrequencia.GetInstance().MdiParent = this;
            FrmRegistroFrequencia.GetInstance().WindowState = FormWindowState.Maximized;
            FrmRegistroFrequencia.GetInstance().Show();
        }

        private void mnuPrincipalAdminstradorUsuarios_Click(object sender, EventArgs e)
        {
            var gerenciamentoUsuario = FrmGerenciamentoUsuario.GetInstance(_usuario);
            gerenciamentoUsuario.MdiParent = this;
            gerenciamentoUsuario.WindowState = FormWindowState.Maximized;
            gerenciamentoUsuario.Show();
        }

        private void mnuPrincipalAjudaSobre_Click(object sender, EventArgs e)
        {
            FrmSobre Sobre = FrmSobre.GetInstance();
            Sobre.MdiParent = this;
            Sobre.Show();
        }

        private void mnuPrincipalAjudaTermosDeUso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este software é proprietário e não pode ser distribuído, " +
                "modificado ou usado sem autorização do titular dos direitos. " +
                "O uso é permitido apenas para clientes licenciados.");
        }

        private void mnuTelaPrincipalArquivoSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuTelaPrincipalArquivoSairDoPrograma_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Você tem certeza que deseja fechar o programa? Alterações não salvas serão perdidas para sempre (isso é bastante tempo)", "Fechar o programa?", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                FrmLogin.GetInstance().Close();
                Close();
            }
        }

        private void mnuPrincipalClienteFrequencia_Click(object sender, EventArgs e)
        {
            FrmFrequencia frequencia = FrmFrequencia.GetInstance(_usuario);
            frequencia.MdiParent = this;
            frequencia.Show();
        }

        private void mnuPrincipalClientePerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = FrmPerfil.GetInstance(_usuario, _usuario.Credencial.Admin);
            perfil.MdiParent = this;
            perfil.Show();
        }

        private void mnuPrincipalClienteTreinos_Click(object sender, EventArgs e)
        {
            FrmProgramacao programacao = FrmProgramacao.GetInstance(_usuario, _usuario);
            programacao.MdiParent = this;
            programacao.Show();
        }

        private void mnuPrincipalClienteAvaliacoes_Click(object sender, EventArgs e)
        {
            FrmAvaliacoes.GetInstance(_usuario);
        }
    }
}
