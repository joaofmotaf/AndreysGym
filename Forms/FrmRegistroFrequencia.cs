using AndreysGym.Entidades;
using AndreysGym.Repositories;

namespace AndreysGym
{
    public partial class RegistroFrequencia : Form
    {
        public RegistroFrequencia()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = UsuarioRepository.Autenticar(txtEmail.Text, txtSenha.Text);
            if (usuario != null)
            {
                if (usuario.Frequencias.Last().Saida == null)
                {
                    usuario.Frequencias.Last().Saida = DateTime.Now;
                }
                else
                {
                    usuario.Frequencias.Add(new Frequencia { Entrada = DateTime.Now, Usuario = usuario }); ;
                }
                lblSucesso.Show();
            }
            else
            {
            }
            txtEmail.Focus();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblSucesso.Hide();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblSucesso.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
        }
    }
}
