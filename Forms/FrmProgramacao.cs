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
    public partial class FrmProgramacao : Form
    {
        private static Usuario _usuarioSelecionado;
        private static List<Programacao> _programacoes;
        private static FrmProgramacao _instance;
        private static Usuario _usuarioAtivo;
        private FrmProgramacao()
        {
            InitializeComponent();
            AtualizarProgramacoes();
            btnAdicionarProgramacao.Visible = _usuarioAtivo.Credencial.Admin;
            btnConcluirTreino.Visible = (_usuarioAtivo.Id == _usuarioSelecionado.Id);
        }
        public static FrmProgramacao GetInstance(Usuario usuarioSelecionado, Usuario usuarioAtivo)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _usuarioSelecionado = usuarioSelecionado;
                _usuarioAtivo = usuarioAtivo;
                _instance = new FrmProgramacao();
            }
            return _instance;
        }
        public static FrmProgramacao GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmProgramacao();
            }
            return _instance;
        }
        private void AtualizarProgramacoes()
        {
            _usuarioSelecionado = UsuarioRepository.FindByIdWCredencial(_usuarioSelecionado.Id);
            _usuarioAtivo = UsuarioRepository.FindByIdWCredencial(_usuarioAtivo.Id);
            _programacoes = ProgramacaoRepository.FindByUsuario(_usuarioSelecionado);
            treProgramacoes.Nodes.Clear();

            foreach (Programacao programacao in _programacoes)
            {
                TreeNode nodeProgramacao = new TreeNode($"Programação de {programacao.DataInicio:d}");
                nodeProgramacao.Tag = programacao;
                foreach (Treino treino in programacao.Treinos)
                {
                    TreeNode nodeTreino;
                    if (treino.Id == _usuarioSelecionado.TreinoAtualId)
                    {
                        nodeTreino = new TreeNode($"Treino {treino.Nome} (Atual)");
                    }
                    else
                    {
                        nodeTreino = new TreeNode($"Treino {treino.Nome}");
                    }

                    nodeTreino.Tag = treino;
                    nodeProgramacao.Nodes.Add(nodeTreino);
                }
                treProgramacoes.Nodes.Insert(0, nodeProgramacao);
            }
            if (treProgramacoes.Nodes.Count != 0)
            {
                treProgramacoes.Nodes[0].Expand();
            }
        }

        private void btnAdicionarProgramacao_Click(object sender, EventArgs e)
        {
            FrmRegistroProgramacao.GetInstance().Show();
        }

        public void SalvarProgramacao(Programacao programacao)
        {
            programacao.Usuario = _usuarioSelecionado;
            _programacoes.Add(programacao);
            ProgramacaoRepository.Save(programacao);
            _usuarioSelecionado.TreinoAtualId = programacao.Treinos.FirstOrDefault().Id;
            UsuarioRepository.Save(_usuarioSelecionado);
            AtualizarProgramacoes();
        }

        private void trvProgramacoes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstExercicios.Items.Clear();
            if (treProgramacoes.SelectedNode.Tag is Treino treino)
            {
                btnConcluirTreino.Enabled = (_usuarioAtivo.TreinoAtualId == treino.Id);
                foreach (Exercicio exercicio in treino.Exercicios)
                {
                    ListViewItem item = new ListViewItem(exercicio.Nome);
                    item.SubItems.Add(exercicio.QuantidadeSeries.ToString());
                    item.SubItems.Add(exercicio.QuantidadeRepeticoes.ToString());

                    item.Tag = exercicio;

                    lstExercicios.Items.Add(item);
                }
            }
        }

        private void btnConcluirTreino_Click(object sender, EventArgs e)
        {
            Programacao programacao = ((Treino)treProgramacoes.SelectedNode.Tag).Programacao;
            var treinoAtual = programacao.Treinos.FirstOrDefault(t => t.Id == _usuarioAtivo.TreinoAtualId);
            var indiceTreinoAtual = programacao.Treinos.IndexOf(treinoAtual);
            if (programacao.Treinos.Count - 1 == indiceTreinoAtual)
            {
                _usuarioAtivo.TreinoAtualId = programacao.Treinos.FirstOrDefault().Id;
            }
            else
            {
                _usuarioAtivo.TreinoAtualId = programacao.Treinos[indiceTreinoAtual + 1].Id;
            }
            UsuarioRepository.Save(_usuarioAtivo);
            AtualizarProgramacoes();
            btnConcluirTreino.Enabled = false;
        }
    }
}
