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
            sairToolStripMenuItem = new ToolStripMenuItem();
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
            termosDeUsoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            mnuTelaPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuTelaPrincipal
            // 
            mnuTelaPrincipal.Items.AddRange(new ToolStripItem[] { mnuPrincipalArquivoSair, mnuPrincipalAdmnistrador, mnuPrincipalCliente, mnuPrincipalAjuda });
            mnuTelaPrincipal.Location = new Point(0, 0);
            mnuTelaPrincipal.Name = "mnuTelaPrincipal";
            mnuTelaPrincipal.Size = new Size(800, 24);
            mnuTelaPrincipal.TabIndex = 1;
            mnuTelaPrincipal.Text = "menuStrip1";
            // 
            // mnuPrincipalArquivoSair
            // 
            mnuPrincipalArquivoSair.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            mnuPrincipalArquivoSair.Name = "mnuPrincipalArquivoSair";
            mnuPrincipalArquivoSair.Size = new Size(61, 20);
            mnuPrincipalArquivoSair.Text = "A&rquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = Properties.Resources.free_exit_icon_2860_thumb;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sai&r";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // mnuPrincipalAdmnistrador
            // 
            mnuPrincipalAdmnistrador.DropDownItems.AddRange(new ToolStripItem[] { mnuPrincipalAdmnistradorCadastrar, mnuPrincipalAdminstradorUsuarios, registrarFrequênciaToolStripMenuItem });
            mnuPrincipalAdmnistrador.Name = "mnuPrincipalAdmnistrador";
            mnuPrincipalAdmnistrador.Size = new Size(139, 20);
            mnuPrincipalAdmnistrador.Text = "Área do &Administrador";
            // 
            // mnuPrincipalAdmnistradorCadastrar
            // 
            mnuPrincipalAdmnistradorCadastrar.Name = "mnuPrincipalAdmnistradorCadastrar";
            mnuPrincipalAdmnistradorCadastrar.Size = new Size(219, 22);
            mnuPrincipalAdmnistradorCadastrar.Text = "Cadastrar usuário";
            mnuPrincipalAdmnistradorCadastrar.Click += mnuPrincipalAdmnistradorCadastrar_Click;
            // 
            // mnuPrincipalAdminstradorUsuarios
            // 
            mnuPrincipalAdminstradorUsuarios.Name = "mnuPrincipalAdminstradorUsuarios";
            mnuPrincipalAdminstradorUsuarios.Size = new Size(219, 22);
            mnuPrincipalAdminstradorUsuarios.Text = "Gerenciamento de Usuarios";
            mnuPrincipalAdminstradorUsuarios.Click += mnuPrincipalAdminstradorUsuarios_Click;
            // 
            // registrarFrequênciaToolStripMenuItem
            // 
            registrarFrequênciaToolStripMenuItem.Name = "registrarFrequênciaToolStripMenuItem";
            registrarFrequênciaToolStripMenuItem.Size = new Size(219, 22);
            registrarFrequênciaToolStripMenuItem.Text = "Registrar Frequência";
            registrarFrequênciaToolStripMenuItem.Click += registrarFrequênciaToolStripMenuItem_Click;
            // 
            // mnuPrincipalCliente
            // 
            mnuPrincipalCliente.DropDownItems.AddRange(new ToolStripItem[] { mnuPrincipalClientePerfil, mnuPrincipalClienteFrequencia, mnuPrincipalClienteTreinos, mnuPrincipalClienteAvaliacoes, mnuPrincipalClientePagamentos });
            mnuPrincipalCliente.Name = "mnuPrincipalCliente";
            mnuPrincipalCliente.Size = new Size(100, 20);
            mnuPrincipalCliente.Text = "Área do &Cliente";
            // 
            // mnuPrincipalClientePerfil
            // 
            mnuPrincipalClientePerfil.Name = "mnuPrincipalClientePerfil";
            mnuPrincipalClientePerfil.Size = new Size(140, 22);
            mnuPrincipalClientePerfil.Text = "Perfil";
            // 
            // mnuPrincipalClienteFrequencia
            // 
            mnuPrincipalClienteFrequencia.Name = "mnuPrincipalClienteFrequencia";
            mnuPrincipalClienteFrequencia.Size = new Size(140, 22);
            mnuPrincipalClienteFrequencia.Text = "Frequência";
            // 
            // mnuPrincipalClienteTreinos
            // 
            mnuPrincipalClienteTreinos.Name = "mnuPrincipalClienteTreinos";
            mnuPrincipalClienteTreinos.Size = new Size(140, 22);
            mnuPrincipalClienteTreinos.Text = "Treinos";
            // 
            // mnuPrincipalClienteAvaliacoes
            // 
            mnuPrincipalClienteAvaliacoes.Name = "mnuPrincipalClienteAvaliacoes";
            mnuPrincipalClienteAvaliacoes.Size = new Size(140, 22);
            mnuPrincipalClienteAvaliacoes.Text = "Avaliações";
            // 
            // mnuPrincipalClientePagamentos
            // 
            mnuPrincipalClientePagamentos.Name = "mnuPrincipalClientePagamentos";
            mnuPrincipalClientePagamentos.Size = new Size(140, 22);
            mnuPrincipalClientePagamentos.Text = "Pagamentos";
            // 
            // mnuPrincipalAjuda
            // 
            mnuPrincipalAjuda.DropDownItems.AddRange(new ToolStripItem[] { termosDeUsoToolStripMenuItem, sobreToolStripMenuItem });
            mnuPrincipalAjuda.Name = "mnuPrincipalAjuda";
            mnuPrincipalAjuda.Size = new Size(50, 20);
            mnuPrincipalAjuda.Text = "A&juda";
            // 
            // termosDeUsoToolStripMenuItem
            // 
            termosDeUsoToolStripMenuItem.Name = "termosDeUsoToolStripMenuItem";
            termosDeUsoToolStripMenuItem.Size = new Size(151, 22);
            termosDeUsoToolStripMenuItem.Text = "Termos de uso";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(151, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuTelaPrincipal);
            IsMdiContainer = true;
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
        private ToolStripMenuItem sairToolStripMenuItem;
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
        private ToolStripMenuItem termosDeUsoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem registrarFrequênciaToolStripMenuItem;
    }
}