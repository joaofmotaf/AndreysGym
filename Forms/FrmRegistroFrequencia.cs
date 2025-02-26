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
                if (usuario.Credencial.Admin)
                {
                    Frequencia ultimaFrequenciaAdmin = FrequenciaRepository.FindByUsuario(usuario)
                        .OrderByDescending(f => f.Entrada)
                        .FirstOrDefault();

                    if (ultimaFrequenciaAdmin == null || ultimaFrequenciaAdmin.Saida != null)
                    {
                        Frequencia frequenciaAdmin = new Frequencia
                        {
                            Entrada = DateTime.Now,
                            Usuario = usuario
                        };
                        usuario.Frequencias.Add(frequenciaAdmin);
                        FrequenciaRepository.Save(frequenciaAdmin);

                        lblSucesso.Text = "Entrada registrada (Admin).";
                    }
                    else
                    {
                        ultimaFrequenciaAdmin.Saida = DateTime.Now;
                        FrequenciaRepository.Save(ultimaFrequenciaAdmin);

                        lblSucesso.Text = "Saída registrada (Admin).";
                    }

                    MostrarMensagem();
                    return;
                }

                if (usuario.Plano == null)
                {
                    lblSucesso.Text = "Usuário sem plano não pode registrar frequência.";
                    MostrarMensagem();
                    return;
                }

                var frequencias = FrequenciaRepository.FindByUsuario(usuario);
                Frequencia ultimaFrequencia = frequencias.OrderByDescending(f => f.Entrada).FirstOrDefault();

                DateTime hoje = DateTime.Today;
                DateTime inicioSemana = hoje.AddDays(-(int)hoje.DayOfWeek);
                DateTime fimSemana = inicioSemana.AddDays(6);

                int frequenciasNaSemana = frequencias.Count(f => f.Entrada.Date >= inicioSemana &&
                                                                 f.Entrada.Date <= fimSemana);

                if (ultimaFrequencia == null || ultimaFrequencia.Saida != null)
                {
                    if (frequenciasNaSemana >= usuario.Plano.QuantidadeDias)
                    {
                        lblSucesso.Text = "Limite de frequência semanal atingido.";
                    }
                    else if (ultimaFrequencia != null && ultimaFrequencia.Entrada.Date == hoje)
                    {
                        lblSucesso.Text = "Já existe um registro de entrada para hoje.";
                    }
                    else
                    {
                        Frequencia frequencia = new Frequencia
                        {
                            Entrada = DateTime.Now,
                            Usuario = usuario
                        };
                        usuario.Frequencias.Add(frequencia);
                        FrequenciaRepository.Save(frequencia);
                        lblSucesso.Text = "Entrada permitida.";
                    }
                }
                else
                {
                    ultimaFrequencia.Saida = DateTime.Now;
                    FrequenciaRepository.Save(ultimaFrequencia);
                    lblSucesso.Text = "Saída permitida.";
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

        private void FrmRegistroFrequencia_Load(object sender, EventArgs e)
        {

        }
    }
}
