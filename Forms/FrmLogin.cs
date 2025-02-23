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
                FrmPrincipal.GetInstance(usuario).Show();
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

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            lblInvalido.Hide();
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            lblInvalido.Hide();
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Email = adm@mail.com\nSenha = admin");
        }
    }
}
