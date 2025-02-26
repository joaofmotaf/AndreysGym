using AndreysGym.Entidades;
using AndreysGym.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace AndreysGym.Forms
{
    public partial class FrmPagamentos : Form
    {
        private static Usuario _usuario;
        private static BindingList<Pagamento> _pagamentos;
        private static FrmPagamentos _instance;
        private FrmPagamentos()
        {
            InitializeComponent();
            _pagamentos = new BindingList<Pagamento>(PagamentoRepository.FindByUsuario(_usuario));
            lstPagamentos.DataSource = _pagamentos;
        }
        public static FrmPagamentos GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmPagamentos();
            }
            return _instance;
        }

        public static FrmPagamentos GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _usuario = usuario;
                _instance = new FrmPagamentos();
            }
            return _instance;
        }

        public void AtualizarPagamentos()
        {
            _pagamentos = new BindingList<Pagamento>(PagamentoRepository.FindByUsuario(_usuario));
            lstPagamentos.DataSource = null;
            lstPagamentos.DataSource = _pagamentos;
        }

        private void btnNovoPagamento_Click(object sender, EventArgs e)
        {
            FrmCadastroPagamento.GetInstance(_usuario).MdiParent = FrmPrincipal.GetInstance();
            FrmCadastroPagamento.GetInstance(_usuario).WindowState = FormWindowState.Maximized;
            FrmCadastroPagamento.GetInstance(_usuario).Show();
            FrmCadastroPagamento.GetInstance(_usuario).BringToFront();
        }
    }
}
