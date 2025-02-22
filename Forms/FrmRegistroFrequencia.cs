using AndreysGym.Entidades;
using AndreysGym.Repositories;

namespace AndreysGym.Forms
{
    public partial class FrmRegistroFrequencia : Form
    {
        private static FrmRegistroFrequencia _instance;
        private FrmRegistroFrequencia()
        {
            InitializeComponent();
        }
        public static FrmRegistroFrequencia GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmRegistroFrequencia();
            }
            return _instance;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = UsuarioRepository.Autenticar(txtEmail.Text, txtSenha.Text);
            if (usuario != null)
            {
                Frequencia ultimaFrequencia = FrequenciaRepository.FindByUsuario(usuario).LastOrDefault();
                if (ultimaFrequencia == null || ultimaFrequencia.Saida != null)
                {
                    Frequencia frequencia = new Frequencia
                    {
                        Entrada = DateTime.Now,
                        Usuario = usuario
                    };
                    usuario.Frequencias.Add(frequencia);
                    FrequenciaRepository.Save(frequencia);
                }
                else
                {
                    ultimaFrequencia.Saida = DateTime.Now;
                    FrequenciaRepository.Save(ultimaFrequencia);
                }
                MostrarMensagem();
            }
            else
            {
            }
            txtEmail.Focus();
            txtEmail.Clear();
            txtSenha.Clear();

        }

        private async void MostrarMensagem()
        {
            lblSucesso.Show();
            await Task.Delay(1500);
            lblSucesso.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            lblSucesso.Hide();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            lblSucesso.Hide();
        }
    }
}
