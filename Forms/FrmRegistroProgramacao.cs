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
    public partial class FrmRegistroProgramacao : Form
    {
        private static List<Programacao> _programacoes;
        private static FrmRegistroProgramacao _instance;
        private FrmRegistroProgramacao()
        {
            InitializeComponent();
            AtualizarProgramacoes();

        }
        public static FrmRegistroProgramacao GetInstance(Usuario usuario)
        {
            _programacoes = ProgramacaoRepository.FindByUsuario(usuario);
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmRegistroProgramacao();
            }
            return _instance;
        }
        private void AtualizarProgramacoes()
        {
            foreach (Programacao programacao in _programacoes)
            {
                TreeNode node = new TreeNode(programacao.DataInicio.ToString("d"));
                trvProgramacoes.Nodes.Add(node);
            }
        }
    }
}
