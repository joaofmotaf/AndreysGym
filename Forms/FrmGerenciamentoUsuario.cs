﻿using System;
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
        private static FrmGerenciamentoUsuario _instance;
        private BindingList<Usuario> _usuarios;
        private Usuario _usuarioSelecionado;
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

        private void btnProgramacoes_Click(object sender, EventArgs e)
        {
            // Abrir janela de visualização de programações, com o botão de adicionar programações ativado
            FrmProgramacao.GetInstance(_usuarioSelecionado).Show();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                _usuarioSelecionado = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                btnPagamentos.Enabled = true;
                btnProgramacoes.Enabled = true;
                btnAvaliacoes.Enabled = true;
                btnFrequencias.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_usuarioSelecionado != null)
            {
                Usuario usuarioComCredencial = UsuarioRepository.FindByIdWCredencial(_usuarioSelecionado.Id);
                FrmPerfil.GetInstance(usuarioComCredencial, true);
                FrmPerfil.GetInstance().Show();

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_usuarioSelecionado != null)
            {
                var resultado = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Excluir Usuário", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    _usuarios.Remove(_usuarioSelecionado);
                    UsuarioRepository.Remove(_usuarioSelecionado);
                    btnPagamentos.Enabled = false;
                    btnProgramacoes.Enabled = false;
                    btnAvaliacoes.Enabled = false;
                    btnFrequencias.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
        }
    }
}
