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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registrarFrequênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroFrequencia.GetInstance().MdiParent = this;
            FrmRegistroFrequencia.GetInstance().WindowState = FormWindowState.Maximized;
            FrmRegistroFrequencia.GetInstance().Show();
        }

        private void mnuPrincipalAdminstradorUsuarios_Click(object sender, EventArgs e)
        {
            FrmGerenciamentoUsuario.GetInstance().MdiParent = this;
            FrmGerenciamentoUsuario.GetInstance().WindowState = FormWindowState.Maximized;
            FrmGerenciamentoUsuario.GetInstance().Show();
        }
    }
}
