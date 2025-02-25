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
    public partial class FrmCadastroPlano : Form
    {
        private BindingList<Plano> _planos;
        private FrmCadastroPlano()
        {
            InitializeComponent();
            cmbPeriodicidade.DataSource = Enum.GetValues(typeof(Periodicidade));
            cmbPeriodicidade.SelectedItem = cmbPeriodicidade.Items[0];
            _planos = new BindingList<Plano>(PlanoRepository.FindAll());
            lstPlanos.DataSource = _planos;
            btnDesativar.Enabled = (lstPlanos.SelectedItem != null && ((Plano)lstPlanos.SelectedItem).Ativo);
        }

        private static FrmCadastroPlano _instance;

        public static FrmCadastroPlano GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmCadastroPlano();
            }
            return _instance;
        }
        private void btnCadastrarPlano_Click(object sender, EventArgs e)
        {
            Plano plano = new Plano()
            {
                Nome = txtNomePlano.Text,
                QuantidadeDias = Convert.ToByte(nudTotalDias.Value),
                Preco = nudValor.Value,
                Periodicidade = (Periodicidade)cmbPeriodicidade.SelectedItem,
                Ativo = true
            };
            txtNomePlano.Clear();

            try
            {
                PlanoRepository.Save(plano);
                _planos.Add(plano);
                lblAviso.Text = "Cadastro efetuado com sucesso";
                lblAviso.ForeColor = Color.Green;
                lblAviso.Show();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException)
            {
                lblAviso.Text = "Plano já cadastrado";
                lblAviso.ForeColor = Color.Red;
            }
            btnDesativar.Enabled = (lstPlanos.SelectedItem != null && ((Plano)lstPlanos.SelectedItem).Ativo);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstPlanos.SelectedItem != null)
            {
                var resultado = MessageBox.Show("Tem certeza que deseja desativar esse plano?", "Desativar plano?", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Plano plano = _planos.First(p => p == (Plano)lstPlanos.SelectedItem);
                    plano.Ativo = false;
                    PlanoRepository.Save(plano);
                }
            }
        }

        private void lstPlanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDesativar.Enabled = (lstPlanos.SelectedItem != null && ((Plano)lstPlanos.SelectedItem).Ativo);
        }
    }
}
