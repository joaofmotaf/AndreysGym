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
        private static Usuario _usuario;
        private static List<Programacao> _programacoes;
        private static FrmProgramacao _instance;
        private static Boolean _admin;
        private FrmProgramacao()
        {
            InitializeComponent();
            AtualizarProgramacoes();
            btnAdicionarProgramacao.Visible = _admin;
        }
        public static FrmProgramacao GetInstance(Usuario usuario, Boolean admin)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _admin = admin;
                _usuario = usuario;
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
            _programacoes = ProgramacaoRepository.FindByUsuario(_usuario);
            treProgramacoes.Nodes.Clear();

            foreach (Programacao programacao in _programacoes)
            {
                TreeNode nodeProgramacao = new TreeNode($"Programação de {programacao.DataInicio:d}");
                nodeProgramacao.Tag = programacao;
                foreach (Treino treino in programacao.Treinos)
                {
                    TreeNode nodeTreino = new TreeNode($"Treino {treino.Nome}");
                    nodeTreino.Tag = treino;
                    nodeProgramacao.Nodes.Add(nodeTreino);
                }
                treProgramacoes.Nodes.Insert(0, nodeProgramacao);
            }
        }

        private void btnAdicionarProgramacao_Click(object sender, EventArgs e)
        {
            FrmRegistroProgramacao.GetInstance().Show();
        }

        public void SalvarProgramacao(Programacao programacao)
        {
            programacao.Usuario = _usuario;
            _programacoes.Add(programacao);
            ProgramacaoRepository.Save(programacao);
            TreeNode nodeProgramacao = new TreeNode($"Programação de {programacao.DataInicio:d}");
            nodeProgramacao.Tag = programacao;

            treProgramacoes.Nodes.Insert(0, nodeProgramacao);
            AtualizarProgramacoes();
        }

        private void trvProgramacoes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstExercicios.Items.Clear();
            if (treProgramacoes.SelectedNode.Tag is Treino treino)
            {
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
    }
}
