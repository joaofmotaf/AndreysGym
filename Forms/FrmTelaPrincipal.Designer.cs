namespace AndreysGym.Forms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuTelaPrincipal = new MenuStrip();
            mnuPrincipalArquivoSair = new ToolStripMenuItem();
            mnuTelaPrincipalArquivoSair = new ToolStripMenuItem();
            mnuTelaPrincipalArquivoSairDoPrograma = new ToolStripMenuItem();
            mnuPrincipalAdmnistrador = new ToolStripMenuItem();
            mnuPrincipalAdmnistradorCadastrar = new ToolStripMenuItem();
            mnuPrincipalAdminstradorUsuarios = new ToolStripMenuItem();
            registrarFrequênciaToolStripMenuItem = new ToolStripMenuItem();
            mnuPrincipalCliente = new ToolStripMenuItem();
            mnuPrincipalClientePerfil = new ToolStripMenuItem();
            mnuPrincipalClienteFrequencia = new ToolStripMenuItem();
            mnuPrincipalClienteTreinos = new ToolStripMenuItem();
            mnuPrincipalClienteAvaliacoes = new ToolStripMenuItem();
            mnuPrincipalClientePagamentos = new ToolStripMenuItem();
            mnuPrincipalAjuda = new ToolStripMenuItem();
            mnuPrincipalAjudaTermosDeUso = new ToolStripMenuItem();
            mnuPrincipalAjudaSobre = new ToolStripMenuItem();
            mnuTelaPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuTelaPrincipal
            // 
            mnuTelaPrincipal.ImageScalingSize = new Size(20, 20);
            mnuTelaPrincipal.Items.AddRange(new ToolStripItem[] { mnuPrincipalArquivoSair, mnuPrincipalAdmnistrador, mnuPrincipalCliente, mnuPrincipalAjuda });
            mnuTelaPrincipal.Location = new Point(0, 0);
            mnuTelaPrincipal.Name = "mnuTelaPrincipal";
            mnuTelaPrincipal.Padding = new Padding(7, 3, 0, 3);
            mnuTelaPrincipal.Size = new Size(914, 30);
            mnuTelaPrincipal.TabIndex = 1;
            mnuTelaPrincipal.Text = "menuStrip1";
            // 
            // mnuPrincipalArquivoSair
            // 
            mnuPrincipalArquivoSair.DropDownItems.AddRange(new ToolStripItem[] { mnuTelaPrincipalArquivoSair, mnuTelaPrincipalArquivoSairDoPrograma });
            mnuPrincipalArquivoSair.Name = "mnuPrincipalArquivoSair";
            mnuPrincipalArquivoSair.Size = new Size(75, 24);
            mnuPrincipalArquivoSair.Text = "A&rquivo";
            // 
            // mnuTelaPrincipalArquivoSair
            // 
            mnuTelaPrincipalArquivoSair.Image = Properties.Resources.free_exit_icon_2860_thumb;
            mnuTelaPrincipalArquivoSair.Name = "mnuTelaPrincipalArquivoSair";
            mnuTelaPrincipalArquivoSair.Size = new Size(224, 26);
            mnuTelaPrincipalArquivoSair.Text = "Sai&r";
            mnuTelaPrincipalArquivoSair.Click += mnuTelaPrincipalArquivoSair_Click;
            // 
            // mnuTelaPrincipalArquivoSairDoPrograma
            // 
            mnuTelaPrincipalArquivoSairDoPrograma.Name = "mnuTelaPrincipalArquivoSairDoPrograma";
            mnuTelaPrincipalArquivoSairDoPrograma.Size = new Size(224, 26);
            mnuTelaPrincipalArquivoSairDoPrograma.Text = "Fechar o Aplicativo";
            mnuTelaPrincipalArquivoSairDoPrograma.Click += mnuTelaPrincipalArquivoSairDoPrograma_Click;
            // 
            // mnuPrincipalAdmnistrador
            // 
            mnuPrincipalAdmnistrador.DropDownItems.AddRange(new ToolStripItem[] { mnuPrincipalAdmnistradorCadastrar, mnuPrincipalAdminstradorUsuarios, registrarFrequênciaToolStripMenuItem });
            mnuPrincipalAdmnistrador.Name = "mnuPrincipalAdmnistrador";
            mnuPrincipalAdmnistrador.Size = new Size(175, 24);
            mnuPrincipalAdmnistrador.Text = "Área do &Administrador";
            // 
            // mnuPrincipalAdmnistradorCadastrar
            // 
            mnuPrincipalAdmnistradorCadastrar.Name = "mnuPrincipalAdmnistradorCadastrar";
            mnuPrincipalAdmnistradorCadastrar.Size = new Size(274, 26);
            mnuPrincipalAdmnistradorCadastrar.Text = "Cadastrar usuário";
            mnuPrincipalAdmnistradorCadastrar.Click += mnuPrincipalAdmnistradorCadastrar_Click;
            // 
            // mnuPrincipalAdminstradorUsuarios
            // 
            mnuPrincipalAdminstradorUsuarios.Name = "mnuPrincipalAdminstradorUsuarios";
            mnuPrincipalAdminstradorUsuarios.Size = new Size(274, 26);
            mnuPrincipalAdminstradorUsuarios.Text = "Gerenciamento de Usuarios";
            mnuPrincipalAdminstradorUsuarios.Click += mnuPrincipalAdminstradorUsuarios_Click;
            // 
            // registrarFrequênciaToolStripMenuItem
            // 
            registrarFrequênciaToolStripMenuItem.Name = "registrarFrequênciaToolStripMenuItem";
            registrarFrequênciaToolStripMenuItem.Size = new Size(274, 26);
            registrarFrequênciaToolStripMenuItem.Text = "Registrar Frequência";
            registrarFrequênciaToolStripMenuItem.Click += registrarFrequênciaToolStripMenuItem_Click;
            // 
            // mnuPrincipalCliente
            // 
            mnuPrincipalCliente.DropDownItems.AddRange(new ToolStripItem[] { mnuPrincipalClientePerfil, mnuPrincipalClienteFrequencia, mnuPrincipalClienteTreinos, mnuPrincipalClienteAvaliacoes, mnuPrincipalClientePagamentos });
            mnuPrincipalCliente.Name = "mnuPrincipalCliente";
            mnuPrincipalCliente.Size = new Size(126, 24);
            mnuPrincipalCliente.Text = "Área do &Cliente";
            // 
            // mnuPrincipalClientePerfil
            // 
            mnuPrincipalClientePerfil.Name = "mnuPrincipalClientePerfil";
            mnuPrincipalClientePerfil.Size = new Size(224, 26);
            mnuPrincipalClientePerfil.Text = "Perfil";
            mnuPrincipalClientePerfil.Click += mnuPrincipalClientePerfil_Click;
            // 
            // mnuPrincipalClienteFrequencia
            // 
            mnuPrincipalClienteFrequencia.Name = "mnuPrincipalClienteFrequencia";
            mnuPrincipalClienteFrequencia.Size = new Size(224, 26);
            mnuPrincipalClienteFrequencia.Text = "Frequência";
            mnuPrincipalClienteFrequencia.Click += mnuPrincipalClienteFrequencia_Click;
            // 
            // mnuPrincipalClienteTreinos
            // 
            mnuPrincipalClienteTreinos.Name = "mnuPrincipalClienteTreinos";
            mnuPrincipalClienteTreinos.Size = new Size(224, 26);
            mnuPrincipalClienteTreinos.Text = "Treinos";
            // 
            // mnuPrincipalClienteAvaliacoes
            // 
            mnuPrincipalClienteAvaliacoes.Name = "mnuPrincipalClienteAvaliacoes";
            mnuPrincipalClienteAvaliacoes.Size = new Size(224, 26);
            mnuPrincipalClienteAvaliacoes.Text = "Avaliações";
            // 
            // mnuPrincipalClientePagamentos
            // 
            mnuPrincipalClientePagamentos.Name = "mnuPrincipalClientePagamentos";
            mnuPrincipalClientePagamentos.Size = new Size(224, 26);
            mnuPrincipalClientePagamentos.Text = "Pagamentos";
            // 
            // mnuPrincipalAjuda
            // 
            mnuPrincipalAjuda.DropDownItems.AddRange(new ToolStripItem[] { mnuPrincipalAjudaTermosDeUso, mnuPrincipalAjudaSobre });
            mnuPrincipalAjuda.Name = "mnuPrincipalAjuda";
            mnuPrincipalAjuda.Size = new Size(62, 24);
            mnuPrincipalAjuda.Text = "A&juda";
            // 
            // mnuPrincipalAjudaTermosDeUso
            // 
            mnuPrincipalAjudaTermosDeUso.Name = "mnuPrincipalAjudaTermosDeUso";
            mnuPrincipalAjudaTermosDeUso.Size = new Size(188, 26);
            mnuPrincipalAjudaTermosDeUso.Text = "Termos de uso";
            mnuPrincipalAjudaTermosDeUso.Click += mnuPrincipalAjudaTermosDeUso_Click;
            // 
            // mnuPrincipalAjudaSobre
            // 
            mnuPrincipalAjudaSobre.Name = "mnuPrincipalAjudaSobre";
            mnuPrincipalAjudaSobre.Size = new Size(188, 26);
            mnuPrincipalAjudaSobre.Text = "Sobre";
            mnuPrincipalAjudaSobre.Click += mnuPrincipalAjudaSobre_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(mnuTelaPrincipal);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "Tela Principal";
            FormClosing += FrmTelaPrincipal_FormClosing;
            mnuTelaPrincipal.ResumeLayout(false);
            mnuTelaPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuTelaPrincipal;
        private ToolStripMenuItem mnuPrincipalArquivoSair;
        private ToolStripMenuItem mnuTelaPrincipalArquivoSair;
        private ToolStripMenuItem mnuPrincipalAdmnistrador;
        private ToolStripMenuItem mnuPrincipalAdmnistradorCadastrar;
        private ToolStripMenuItem mnuPrincipalAdminstradorUsuarios;
        private ToolStripMenuItem mnuPrincipalCliente;
        private ToolStripMenuItem mnuPrincipalClientePerfil;
        private ToolStripMenuItem mnuPrincipalClienteFrequencia;
        private ToolStripMenuItem mnuPrincipalClienteTreinos;
        private ToolStripMenuItem mnuPrincipalClienteAvaliacoes;
        private ToolStripMenuItem mnuPrincipalClientePagamentos;
        private ToolStripMenuItem mnuPrincipalAjuda;
        private ToolStripMenuItem mnuPrincipalAjudaTermosDeUso;
        private ToolStripMenuItem mnuPrincipalAjudaSobre;
        private ToolStripMenuItem registrarFrequênciaToolStripMenuItem;
        private ToolStripMenuItem mnuTelaPrincipalArquivoSairDoPrograma;
    }
}