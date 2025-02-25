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

namespace AndreysGym.Forms
{
    public partial class FrmAvaliacoes: Form
    {
        private static Usuario _usuarioSelecionado;
        private static Usuario _usuarioLogado;
        private static FrmAvaliacoes _instance;
        private FrmAvaliacoes()
        {
            InitializeComponent();
            btnCadastrarAvaliacao.Visible = (_usuarioLogado.Credencial.Admin && _usuarioLogado.Id != _usuarioSelecionado.Id);
            AtualizarAvaliacoes();
        }
        public static FrmAvaliacoes GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _usuarioSelecionado = usuario;
                _usuarioLogado = usuario;
                _instance = new FrmAvaliacoes();
            }
            return _instance;
        }

        public static FrmAvaliacoes GetInstance(Usuario usuarioSelecionado, Usuario usuarioLogado)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _usuarioSelecionado = usuarioSelecionado;
                _usuarioLogado = usuarioLogado;
                _instance = new FrmAvaliacoes();
            }
            return _instance;
        }

        private void AtualizarAvaliacoes()
        {
            lstAvaliacoes.Items.Clear();
            var avaliacoes = AvaliacaoRepository.FindByUsuario(_usuarioSelecionado);
            _usuarioSelecionado.Avaliacoes = avaliacoes;
            for (int i = 0; i < avaliacoes.Count; i++)
            {
                avaliacoes[i].Usuario = _usuarioSelecionado;
                lstAvaliacoes.Items.Insert(0, avaliacoes[i]);
            }
            if (lstAvaliacoes.Items.Count > 0)
            {
                proAvaliacao.SelectedObject = (Avaliacao)lstAvaliacoes.Items[0];
            }
        }

        private void lstAvaliacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstAvaliacoes.SelectedItems.Count > 0)
                proAvaliacao.SelectedObject = (Avaliacao)lstAvaliacoes.SelectedItem;
        }

        private void btnCadastrarAvaliacao_Click(object sender, EventArgs e)
        {
            var cadastrarAvaliacao = FrmCadastroAvaliacao.GetInstance(_usuarioSelecionado, _usuarioLogado);
            cadastrarAvaliacao.MdiParent = FrmPrincipal.GetInstance();
            cadastrarAvaliacao.WindowState = FormWindowState.Maximized;
            cadastrarAvaliacao.Show();
        }
        public void SalvarAvaliacao(Avaliacao avaliacao)
        {
            AvaliacaoRepository.Save(avaliacao);
            AtualizarAvaliacoes();
        }
    }
}
