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
        private FrmProgramacao()
        {
            InitializeComponent();
            AtualizarProgramacoes();

        }
        public static FrmProgramacao GetInstance(Usuario usuario)
        {
            _usuario = usuario;
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
                TreeNode nodeProgramacao = new TreeNode($"Programação de {programacao.DataInicio.ToString("d")}");
                nodeProgramacao.Tag = programacao;
                foreach (Treino treino in programacao.Treinos)
                {
                    TreeNode nodeTreino = new TreeNode($"Treino {treino.Nome.ToString()}");
                    nodeTreino.Tag = treino;
                    nodeProgramacao.Nodes.Add(nodeTreino);
                }
                treProgramacoes.Nodes.Insert(0, nodeProgramacao);
            }
        }

        private void btnAdicionarProgramacao_Click(object sender, EventArgs e)
        {
            Programacao programacao = new Programacao
            {
                DataInicio = DateTime.Today
            };
            _programacoes.Add(programacao);
            TreeNode nodeProgramacao = new TreeNode($"Programação de {programacao.DataInicio.ToString("d")}");
            nodeProgramacao.Tag = programacao;

            treProgramacoes.Nodes.Insert(0, nodeProgramacao);

            FrmRegistroProgramacao.GetInstance(programacao).Show();
        }

        private void trvProgramacoes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnEditarProgramacao.Enabled = treProgramacoes.SelectedNode.Tag is Programacao;
        }
    }
}
