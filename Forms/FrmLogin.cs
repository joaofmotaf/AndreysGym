using AndreysGym.Entidades;
using AndreysGym.Repositories;

namespace AndreysGym.Forms
{
    public partial class FrmLogin : Form
    {
        private static FrmLogin _instance;
        private FrmLogin()
        {
            InitializeComponent();
        }
        public static FrmLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmLogin();
            }
            return _instance;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = UsuarioRepository.Autenticar(txtEmail.Text, txtSenha.Text);
            if (usuario != null)
            {
                FrmTelaPrincipal.GetInstance(usuario).Show();
                Hide();
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
