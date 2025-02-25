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
    public partial class FrmCadastroPagamento : Form
    {
        private static FrmCadastroPagamento _instance;
        private static Usuario _usuario;
        private FrmCadastroPagamento()
        {
            InitializeComponent();
        }

        private FrmCadastroPagamento(Usuario usuario)
        {
            InitializeComponent();

            _usuario = UsuarioRepository.FindByIdWCredencial(usuario.Id);

            txtNome.Text = _usuario.Nome;
            txtEmail.Text = _usuario.Credencial.Email;
            txtCpf.Text = Convert.ToString(_usuario.Cpf);

            mtbPagamento.Text = Convert.ToString(DateTime.Now);
        }

        public static FrmCadastroPagamento GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmCadastroPagamento(usuario);
            }
            return _instance;
        }
    }
}
