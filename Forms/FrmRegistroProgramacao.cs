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
using ZstdSharp.Unsafe;

namespace AndreysGym.Forms
{
    public partial class FrmRegistroProgramacao : Form
    {
        private static FrmRegistroProgramacao _instance;
        private static Programacao _programacao;
        private FrmRegistroProgramacao()
        {
            InitializeComponent();
            AtualizarTreinos();
            btnExcluirTreino.Enabled = false;
            btnAdicionarExercicio.Enabled = false;
            btnExcluirExercicio.Enabled = false;
        }
        public static FrmRegistroProgramacao GetInstance(Programacao programacao)
        {
            _programacao = programacao;
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmRegistroProgramacao();
            }
            return _instance;
        }
        private void AtualizarTreinos()
        {
            treTreinos.Nodes.Clear();

            foreach (Treino treino in _programacao.Treinos)
            {
                TreeNode nodeTreino = new TreeNode($"Treino {treino.Nome.ToString()}");
                treTreinos.Nodes.Add(nodeTreino);
                nodeTreino.Tag = treino;
            }
        }

        private void AtualizarExercicios()
        {
            lstExercicios.Items.Clear();
            lblTreino.Text = $"Treino {((Treino)treTreinos.SelectedNode.Tag).Nome.ToString()}";
            foreach (Exercicio exercicio in ((Treino)treTreinos.SelectedNode.Tag).Exercicios)
            {
                ListViewItem item = new ListViewItem(exercicio.Nome);
                item.SubItems.Add(exercicio.QuantidadeSeries.ToString());
                item.SubItems.Add(exercicio.QuantidadeRepeticoes.ToString());

                item.Tag = exercicio;

                lstExercicios.Items.Add(item);
            }
        }

        private void treTreinos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnExcluirTreino.Enabled = (treTreinos.SelectedNode != null);
            btnAdicionarExercicio.Enabled = (treTreinos.SelectedNode != null);
            btnExcluirExercicio.Enabled = (treTreinos.SelectedNode != null);
            AtualizarExercicios();
        }

        private void btnAdicionarTreino_Click(object sender, EventArgs e)
        {
            Treino treino = new Treino
            {
                Programacao = _programacao
            };
            if (_programacao.Treinos.Count == 0)
            {
                treino.Nome = 'A';
            }
            else
            {
                treino.Nome = (Char)(_programacao.Treinos.Last().Nome + 1);
            }
            _programacao.Treinos.Add(treino);
            TreeNode nodeTreino = new TreeNode($"Treino {treino.Nome.ToString()}");
            nodeTreino.Tag = treino;
            treTreinos.Nodes.Add(nodeTreino);
            treTreinos.SelectedNode = nodeTreino;
        }

        private void btnExcluirTreino_Click(object sender, EventArgs e)
        {
            var indiceTreinoSelecionado = _programacao.Treinos.IndexOf((Treino)treTreinos.SelectedNode.Tag);
            _programacao.Treinos.Remove((Treino)treTreinos.SelectedNode.Tag);
            for (int i = indiceTreinoSelecionado; i < _programacao.Treinos.Count; i++)
            {
                _programacao.Treinos[i].Nome -= (Char)1;
            }
            AtualizarTreinos();
            lstExercicios.Items.Clear();
            lblTreino.Text = "Nenhum treino selecionado";
        }

        private void btnAdicionarExercicio_Click(object sender, EventArgs e)
        {
            Exercicio exercicio = new Exercicio
            {
                Nome = txtNomeExercicio.Text,
                QuantidadeSeries = (UInt16)numSeries.Value,
                QuantidadeRepeticoes = (UInt16)numRepeticoes.Value,
                Treino = (Treino)treTreinos.SelectedNode.Tag
            };
            ((Treino)treTreinos.SelectedNode.Tag).Exercicios.Add(exercicio);
            ListViewItem itemExercicio = new ListViewItem(exercicio.Nome);
            itemExercicio.SubItems.Add(exercicio.QuantidadeSeries.ToString());
            itemExercicio.SubItems.Add(exercicio.QuantidadeRepeticoes.ToString());

            itemExercicio.Tag = exercicio;

            lstExercicios.Items.Add(itemExercicio);
        }
    }
}
