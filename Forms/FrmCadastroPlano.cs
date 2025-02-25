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
        private FrmCadastroPlano()
        {
            InitializeComponent();
            cmbPeriodicidade.DataSource = Enum.GetValues(typeof(Periodicidade));
           
        }

        private void btnCadastrarPlano_Click(object sender, EventArgs e)
        {
            Plano plano = new Plano()
            {
                Nome = txtNomePlano.Text,
                QuantidadeDias = Convert.ToByte(nudTotalDias.Value),
                Preco = nudValor.Value,
                
            };
            txtNomePlano.Clear();
           
            try
            {
                PlanoRepository.Save(plano);
                lblAviso.Text = "Cadastro efetuado com sucesso";
                lblAviso.ForeColor = Color.Green;
                lblAviso.Show();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException exception)
            {
                lblAviso.Text = "Plano já cadastrado";
                lblAviso.ForeColor = Color.Red;
            }
        }
    }
}
