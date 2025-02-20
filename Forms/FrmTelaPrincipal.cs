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
    public partial class FrmTelaPrincipal : Form
    {
        private static Usuario _usuario { get; set; }
        private FrmTelaPrincipal()
        {
            InitializeComponent();
        }
        private static FrmTelaPrincipal _instance;
        public static FrmTelaPrincipal GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _usuario = usuario;
                _instance = new FrmTelaPrincipal();
            }
            return _instance;
        }

        private void FrmTelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin.GetInstance().Show();
        }
    }
}
