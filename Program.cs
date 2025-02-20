using AndreysGym.Repositories;
using AndreysGym.Entidades;
using AndreysGym.Forms;

namespace AndreysGym
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (UsuarioRepository.FindAll().Count == 0)
            {
                Credencial credencial = new Credencial
                {
                    Email = "adm@mail.com",
                    Senha = "admin",
                    Admin = true
                };
                Usuario usuario = new Usuario
                {
                    Nome = "Admin",
                    Cpf = 0,
                    DataNascimento = new DateTime(2007, 08, 28),
                    Credencial = credencial
                };
                credencial.Usuario = usuario;
                UsuarioRepository.Save(usuario);
                MessageBox.Show("Email: adm@mail.com\nSenha: admin", "Usuário padrão");
            }
            Application.Run(FrmLogin.GetInstance());
        }
    }
}