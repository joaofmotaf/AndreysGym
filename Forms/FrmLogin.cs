using AndreysGym.Entidades;
using AndreysGym.Repositories;

namespace AndreysGym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = UsuarioRepository.Autenticar(txtEmail.Text, txtSenha.Text);
            if (usuario != null)
            {
                MessageBox.Show("Login efetuado com sucesso");
            }
            else
            {
                lblInvalido.Show();
            }
            txtEmail.SelectAll();
            txtEmail.Focus();
            txtSenha.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblInvalido.Hide();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblInvalido.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
        }
    }
}
