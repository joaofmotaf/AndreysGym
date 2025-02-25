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
    public partial class FrmRegistroProgramacao : Form
    {
        private static FrmRegistroProgramacao _instance;
        private static Programacao _programacao;
        private FrmRegistroProgramacao()
        {
            InitializeComponent();
            _programacao = new Programacao()
            {
                DataInicio = DateTime.Today
            };
            AtualizarTreinos();
            btnSalvar.Enabled = false;
            txtNomeExercicio.Enabled = false;
            numSeries.Enabled = false;
            numRepeticoes.Enabled = false;
            btnExcluirTreino.Enabled = false;
            btnAdicionarExercicio.Enabled = false;
            btnExcluirExercicio.Enabled = false;
        }
        public static FrmRegistroProgramacao GetInstance()
        {
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
            btnAdicionarExercicio.Enabled = (treTreinos.SelectedNode != null);
            btnExcluirTreino.Enabled = (treTreinos.SelectedNode != null);
            txtNomeExercicio.Enabled = (treTreinos.SelectedNode != null);
            numRepeticoes.Enabled = (treTreinos.SelectedNode != null);
            numSeries.Enabled = (treTreinos.SelectedNode != null);

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

            AtualizarBotoes();
        }

        private void btnExcluirTreino_Click(object sender, EventArgs e)
        {
            Treino treino = (Treino)treTreinos.SelectedNode.Tag;
            treino.Exercicios.Clear();
            treino.Programacao = null;
            var indiceTreinoSelecionado = _programacao.Treinos.IndexOf(treino);
            _programacao.Treinos.Remove(treino);
            for (int i = indiceTreinoSelecionado; i < _programacao.Treinos.Count; i++)
            {
                _programacao.Treinos[i].Nome -= (Char)1;
            }
            AtualizarTreinos();
            lstExercicios.Items.Clear();
            lblTreino.Text = "Nenhum treino selecionado";

            AtualizarBotoes();
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
            txtNomeExercicio.Clear();
            numSeries.Value = 0;
            numRepeticoes.Value = 0;
            ((Treino)treTreinos.SelectedNode.Tag).Exercicios.Add(exercicio);
            ListViewItem itemExercicio = new ListViewItem(exercicio.Nome);
            itemExercicio.SubItems.Add(exercicio.QuantidadeSeries.ToString());
            itemExercicio.SubItems.Add(exercicio.QuantidadeRepeticoes.ToString());
            itemExercicio.Tag = exercicio;
            lstExercicios.Items.Add(itemExercicio);

            AtualizarBotoes();
        }

        private void btnExcluirExercicio_Click(object sender, EventArgs e)
        {
            Exercicio exercicio = (Exercicio)lstExercicios.SelectedItems[0].Tag;
            exercicio.Treino = null;
            ((Treino)treTreinos.SelectedNode.Tag).Exercicios.Remove(exercicio);

            lstExercicios.Items.Remove(lstExercicios.SelectedItems[0]);

            AtualizarBotoes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FrmProgramacao.GetInstance().SalvarProgramacao(_programacao);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstExercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            btnSalvar.Enabled = (treTreinos.Nodes.Count > 0);
            btnExcluirTreino.Enabled = (treTreinos.SelectedNode != null);
            btnAdicionarExercicio.Enabled = (treTreinos.SelectedNode != null);
            btnExcluirExercicio.Enabled = (lstExercicios.SelectedIndices.Count > 0);
            txtNomeExercicio.Enabled = (treTreinos.SelectedNode != null);
            numRepeticoes.Enabled = (treTreinos.SelectedNode != null);
            numSeries.Enabled = (treTreinos.SelectedNode != null);
        }
    }
}
