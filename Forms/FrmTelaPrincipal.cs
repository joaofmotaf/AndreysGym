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
            FrmCadastro.GetInstance().MdiParent = FrmPrincipal.GetInstance();
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
            frequencia.WindowState = FormWindowState.Maximized;
            frequencia.Show();
        }

        private void mnuPrincipalClientePerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = FrmPerfil.GetInstance(_usuario, _usuario.Credencial.Admin);
            perfil.MdiParent = this;
            perfil.WindowState = FormWindowState.Maximized;
            perfil.Show();
        }

        private void mnuPrincipalClienteTreinos_Click(object sender, EventArgs e)
        {
            FrmProgramacao programacao = FrmProgramacao.GetInstance(_usuario, _usuario);
            programacao.MdiParent = this;
            programacao.WindowState = FormWindowState.Maximized;
            programacao.Show();
        }

        private void mnuPrincipalClienteAvaliacoes_Click(object sender, EventArgs e)
        {
            var avaliacoes = FrmAvaliacoes.GetInstance(_usuario);
            avaliacoes.MdiParent = this;
            avaliacoes.WindowState = FormWindowState.Maximized;
            avaliacoes.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var mdiClient = this.Controls.OfType<MdiClient>().FirstOrDefault();

            if (mdiClient != null)
            {
                mdiClient.BackgroundImage = this.BackgroundImage;
                mdiClient.BackgroundImageLayout = ImageLayout.Stretch; // Ajuste conforme necessário
            }
        }

        private void cadastrarPlanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPlano.GetInstance().MdiParent = FrmPrincipal.GetInstance();
            FrmCadastroPlano.GetInstance().WindowState = FormWindowState.Maximized;
            FrmCadastroPlano.GetInstance().Show();
        }

        private void mnuPrincipalAdmnistradorCadastrarPagamentos_Click(object sender, EventArgs e)
        {
            FrmCadastroPagamento.GetInstance(_usuario).MdiParent = FrmPrincipal.GetInstance();
            FrmCadastroPagamento.GetInstance(_usuario).WindowState = FormWindowState.Maximized;
            FrmCadastroPagamento.GetInstance(_usuario).Show();
        }
    }
}
