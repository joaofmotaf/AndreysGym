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
using AndreysGym.Forms;
using AndreysGym.Repositories;

namespace AndreysGym.Forms
{
    public partial class FrmGerenciamentoUsuario : Form
    {
        private static FrmGerenciamentoUsuario _instance { get; set; }
        private BindingList<Usuario> _usuarios { get; set; }
        private FrmGerenciamentoUsuario()
        {
            InitializeComponent();
            _usuarios = new BindingList<Usuario>(UsuarioRepository.FindAll());
            usuarioBindingSource.DataSource = _usuarios;
        }
        public static FrmGerenciamentoUsuario GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmGerenciamentoUsuario();
            }
            return _instance;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var usuariosEncontrados = UsuarioRepository.FindByPartialName(txtPesquisa.Text);

            _usuarios.Clear();
            foreach (var usuario in usuariosEncontrados)
            {
                _usuarios.Add(usuario);
            }
        }
    }
}
