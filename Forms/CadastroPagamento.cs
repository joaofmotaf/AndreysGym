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
    public partial class FrmCadastroPagamento : Form
    {
        private static FrmCadastroPagamento _instance;
        private FrmCadastroPagamento()
        {
            InitializeComponent();

            mtbPagamento.Text = Convert.ToString(DateTime.Now);
        }

        public static FrmCadastroPagamento GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmCadastroPagamento();
            }
            return _instance;
        }
    }
}
