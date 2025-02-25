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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            mnuTelaPrincipal = new MenuStrip();
            mnuPrincipalArquivoSair = new ToolStripMenuItem();
            mnuTelaPrincipalArquivoSair = new ToolStripMenuItem();
            mnuTelaPrincipalArquivoSairDoPrograma = new ToolStripMenuItem();
            mnuPrincipalAdmnistrador = new ToolStripMenuItem();
            mnuPrincipalAdmnistradorCadastrar = new ToolStripMenuItem();
            mnuPrincipalAdminstradorUsuarios = new ToolStripMenuItem();
            registrarFrequênciaToolStripMenuItem = new ToolStripMenuItem();
            áreaDoAdministradorToolStripMenuItem = new ToolStripMenuItem();
            mnuPrincipalCliente = new ToolStripMenuItem();
            mnuPrincipalClientePerfil = new ToolStripMenuItem();
            mnuPrincipalClienteFrequencia = new ToolStripMenuItem();
            mnuPrincipalClienteTreinos = new ToolStripMenuItem();
            mnuPrincipalClienteAvaliacoes = new ToolStripMenuItem();
            mnuPrincipalClientePagamentos = new ToolStripMenuItem();
            mnuPrincipalAjuda = new ToolStripMenuItem();
            mnuPrincipalAjudaTermosDeUso = new ToolStripMenuItem();
            mnuPrincipalAjudaSobre = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mnuTelaPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_removebg_preview;
            pictureBox2.Location = new Point(-573, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(997, 569);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.image_removebg_preview;
            pictureBox1.Location = new Point(225, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(964, 569);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // mnuTelaPrincipal
            // 
            mnuTelaPrincipal.ImageScalingSize = new Size(20, 20);
            mnuTelaPrincipal.Items.AddRange(new ToolStripItem[] { mnuPrincipalArquivoSair, mnuPrincipalAdmnistrador, mnuPrincipalCliente, mnuPrincipalAjuda });
            mnuTelaPrincipal.Location = new Point(0, 0);
            mnuTelaPrincipal.Name = "mnuTelaPrincipal";
            mnuTelaPrincipal.Padding = new Padding(7, 3, 0, 3);
            mnuTelaPrincipal.Size = new Size(914, 30);
            mnuTelaPrincipal.TabIndex = 9;
            mnuTelaPrincipal.Text = "menuStrip1";
            mnuTelaPrincipal.ItemClicked += mnuTelaPrincipal_ItemClicked;
            // 
            // mnuPrincipalArquivoSair
            // 
            mnuPrincipalArquivoSair.DropDownItems.AddRange(new ToolStripItem[] { mnuTelaPrincipalArquivoSair, mnuTelaPrincipalArquivoSairDoPrograma });
            mnuPrincipalArquivoSair.Name = "mnuPrincipalArquivoSair";
            mnuPrincipalArquivoSair.Size = new Size(75, 24);
            mnuPrincipalArquivoSair.Text = "A&rquivo";
            mnuPrincipalArquivoSair.Click += mnuPrincipalArquivoSair_Click;
            // 
            // mnuTelaPrincipalArquivoSair
            // 
            mnuTelaPrincipalArquivoSair.Image = (Image)resources.GetObject("mnuTelaPrincipalArquivoSair.Image");
            mnuTelaPrincipalArquivoSair.Name = "mnuTelaPrincipalArquivoSair";
            mnuTelaPrincipalArquivoSair.Size = new Size(404, 26);
            mnuTelaPrincipalArquivoSair.Text = "Sai&r";
            mnuTelaPrincipalArquivoSair.Click += mnuTelaPrincipalArquivoSair_Click;
            // 
            // mnuTelaPrincipalArquivoSairDoPrograma
            // 
            mnuTelaPrincipalArquivoSairDoPrograma.Image = (Image)resources.GetObject("mnuTelaPrincipalArquivoSairDoPrograma.Image");
            mnuTelaPrincipalArquivoSairDoPrograma.Name = "mnuTelaPrincipalArquivoSairDoPrograma";
            mnuTelaPrincipalArquivoSairDoPrograma.Size = new Size(404, 26);
            mnuTelaPrincipalArquivoSairDoPrograma.Text = "Fechar o Aplicativo (só pd aparecer pra admin)";
            mnuTelaPrincipalArquivoSairDoPrograma.Click += mnuTelaPrincipalArquivoSairDoPrograma_Click;
            // 
            // mnuPrincipalAdmnistrador
            // 
            mnuPrincipalAdmnistrador.DropDownItems.AddRange(new ToolStripItem[] { mnuPrincipalAdmnistradorCadastrar, mnuPrincipalAdminstradorUsuarios, registrarFrequênciaToolStripMenuItem, áreaDoAdministradorToolStripMenuItem });
            mnuPrincipalAdmnistrador.Name = "mnuPrincipalAdmnistrador";
            mnuPrincipalAdmnistrador.Size = new Size(175, 24);
            mnuPrincipalAdmnistrador.Text = "Área do &Administrador";
            mnuPrincipalAdmnistrador.Click += mnuPrincipalAdmnistrador_Click;
            // 
            // mnuPrincipalAdmnistradorCadastrar
            // 
            mnuPrincipalAdmnistradorCadastrar.Image = (Image)resources.GetObject("mnuPrincipalAdmnistradorCadastrar.Image");
            mnuPrincipalAdmnistradorCadastrar.Name = "mnuPrincipalAdmnistradorCadastrar";
            mnuPrincipalAdmnistradorCadastrar.Size = new Size(274, 26);
            mnuPrincipalAdmnistradorCadastrar.Text = "Cadastrar usuário";
            mnuPrincipalAdmnistradorCadastrar.Click += mnuPrincipalAdmnistradorCadastrar_Click;
            // 
            // mnuPrincipalAdminstradorUsuarios
            // 
            mnuPrincipalAdminstradorUsuarios.Image = (Image)resources.GetObject("mnuPrincipalAdminstradorUsuarios.Image");
            mnuPrincipalAdminstradorUsuarios.Name = "mnuPrincipalAdminstradorUsuarios";
            mnuPrincipalAdminstradorUsuarios.Size = new Size(274, 26);
            mnuPrincipalAdminstradorUsuarios.Text = "Gerenciamento de Usuarios";
            mnuPrincipalAdminstradorUsuarios.Click += mnuPrincipalAdminstradorUsuarios_Click;
            // 
            // registrarFrequênciaToolStripMenuItem
            // 
            registrarFrequênciaToolStripMenuItem.Image = (Image)resources.GetObject("registrarFrequênciaToolStripMenuItem.Image");
            registrarFrequênciaToolStripMenuItem.Name = "registrarFrequênciaToolStripMenuItem";
            registrarFrequênciaToolStripMenuItem.Size = new Size(274, 26);
            registrarFrequênciaToolStripMenuItem.Text = "Registrar Frequência";
            registrarFrequênciaToolStripMenuItem.Click += registrarFrequênciaToolStripMenuItem_Click;
            // 
            // áreaDoAdministradorToolStripMenuItem
            // 
            áreaDoAdministradorToolStripMenuItem.Image = (Image)resources.GetObject("áreaDoAdministradorToolStripMenuItem.Image");
            áreaDoAdministradorToolStripMenuItem.Name = "áreaDoAdministradorToolStripMenuItem";
            áreaDoAdministradorToolStripMenuItem.Size = new Size(274, 26);
            áreaDoAdministradorToolStripMenuItem.Text = "Área do &Administrador";
            // 
            // mnuPrincipalCliente
            // 
            mnuPrincipalCliente.DropDownItems.AddRange(new ToolStripItem[] { mnuPrincipalClientePerfil, mnuPrincipalClienteFrequencia, mnuPrincipalClienteTreinos, mnuPrincipalClienteAvaliacoes, mnuPrincipalClientePagamentos });
            mnuPrincipalCliente.Name = "mnuPrincipalCliente";
            mnuPrincipalCliente.Size = new Size(126, 24);
            mnuPrincipalCliente.Text = "Área do &Cliente";
            mnuPrincipalCliente.Click += mnuPrincipalCliente_Click;
            // 
            // mnuPrincipalClientePerfil
            // 
            mnuPrincipalClientePerfil.Image = (Image)resources.GetObject("mnuPrincipalClientePerfil.Image");
            mnuPrincipalClientePerfil.Name = "mnuPrincipalClientePerfil";
            mnuPrincipalClientePerfil.Size = new Size(224, 26);
            mnuPrincipalClientePerfil.Text = "Perfil";
            mnuPrincipalClientePerfil.Click += mnuPrincipalClientePerfil_Click;
            // 
            // mnuPrincipalClienteFrequencia
            // 
            mnuPrincipalClienteFrequencia.Image = (Image)resources.GetObject("mnuPrincipalClienteFrequencia.Image");
            mnuPrincipalClienteFrequencia.Name = "mnuPrincipalClienteFrequencia";
            mnuPrincipalClienteFrequencia.Size = new Size(224, 26);
            mnuPrincipalClienteFrequencia.Text = "Frequência";
            mnuPrincipalClienteFrequencia.Click += mnuPrincipalClienteFrequencia_Click;
            // 
            // mnuPrincipalClienteTreinos
            // 
            mnuPrincipalClienteTreinos.Image = (Image)resources.GetObject("mnuPrincipalClienteTreinos.Image");
            mnuPrincipalClienteTreinos.Name = "mnuPrincipalClienteTreinos";
            mnuPrincipalClienteTreinos.Size = new Size(224, 26);
            mnuPrincipalClienteTreinos.Text = "Treinos";
            mnuPrincipalClienteTreinos.Click += mnuPrincipalClienteTreinos_Click;
            // 
            // mnuPrincipalClienteAvaliacoes
            // 
            mnuPrincipalClienteAvaliacoes.Image = (Image)resources.GetObject("mnuPrincipalClienteAvaliacoes.Image");
            mnuPrincipalClienteAvaliacoes.Name = "mnuPrincipalClienteAvaliacoes";
            mnuPrincipalClienteAvaliacoes.Size = new Size(224, 26);
            mnuPrincipalClienteAvaliacoes.Text = "Avaliações";
            mnuPrincipalClienteAvaliacoes.Click += mnuPrincipalClienteAvaliacoes_Click;
            // 
            // mnuPrincipalClientePagamentos
            // 
            mnuPrincipalClientePagamentos.Image = (Image)resources.GetObject("mnuPrincipalClientePagamentos.Image");
            mnuPrincipalClientePagamentos.Name = "mnuPrincipalClientePagamentos";
            mnuPrincipalClientePagamentos.Size = new Size(224, 26);
            mnuPrincipalClientePagamentos.Text = "Pagamentos";
            mnuPrincipalClientePagamentos.Click += mnuPrincipalClientePagamentos_Click;
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
            mnuPrincipalAjudaTermosDeUso.Image = (Image)resources.GetObject("mnuPrincipalAjudaTermosDeUso.Image");
            mnuPrincipalAjudaTermosDeUso.Name = "mnuPrincipalAjudaTermosDeUso";
            mnuPrincipalAjudaTermosDeUso.Size = new Size(224, 26);
            mnuPrincipalAjudaTermosDeUso.Text = "Termos de uso";
            mnuPrincipalAjudaTermosDeUso.Click += mnuPrincipalAjudaTermosDeUso_Click_1;
            // 
            // mnuPrincipalAjudaSobre
            // 
            mnuPrincipalAjudaSobre.Image = (Image)resources.GetObject("mnuPrincipalAjudaSobre.Image");
            mnuPrincipalAjudaSobre.Name = "mnuPrincipalAjudaSobre";
            mnuPrincipalAjudaSobre.Size = new Size(224, 26);
            mnuPrincipalAjudaSobre.Text = "Sobre";
            mnuPrincipalAjudaSobre.Click += mnuPrincipalAjudaSobre_Click_1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(mnuTelaPrincipal);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "Tela Principal";
            FormClosing += FrmTelaPrincipal_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mnuTelaPrincipal.ResumeLayout(false);
            mnuTelaPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private MenuStrip mnuTelaPrincipal;
        private ToolStripMenuItem mnuPrincipalArquivoSair;
        private ToolStripMenuItem mnuTelaPrincipalArquivoSair;
        private ToolStripMenuItem mnuTelaPrincipalArquivoSairDoPrograma;
        private ToolStripMenuItem mnuPrincipalAdmnistrador;
        private ToolStripMenuItem mnuPrincipalAdmnistradorCadastrar;
        private ToolStripMenuItem mnuPrincipalAdminstradorUsuarios;
        private ToolStripMenuItem registrarFrequênciaToolStripMenuItem;
        private ToolStripMenuItem mnuPrincipalCliente;
        private ToolStripMenuItem mnuPrincipalClientePerfil;
        private ToolStripMenuItem mnuPrincipalClienteFrequencia;
        private ToolStripMenuItem mnuPrincipalClienteTreinos;
        private ToolStripMenuItem mnuPrincipalClienteAvaliacoes;
        private ToolStripMenuItem mnuPrincipalClientePagamentos;
        private ToolStripMenuItem mnuPrincipalAjuda;
        private ToolStripMenuItem mnuPrincipalAjudaTermosDeUso;
        private ToolStripMenuItem mnuPrincipalAjudaSobre;
        private ToolStripMenuItem áreaDoAdministradorToolStripMenuItem;
    }
}