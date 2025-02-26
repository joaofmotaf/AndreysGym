using AndreysGym.Entidades;
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
    public partial class FrmPagamentos: Form
    {
        private static FrmPagamentos _instance;
        private FrmPagamentos()
        {
            InitializeComponent();
            lstPagamentos.DataSource = new BindingList<Pagamento>();
        }
        public static FrmPagamentos GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmPagamentos();
            }
            return _instance;
        }
    }
}
