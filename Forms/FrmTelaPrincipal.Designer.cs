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
            pictureBox2.Location = new Point(-605, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(853, 545);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview;
            pictureBox1.Location = new Point(204, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(853, 545);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            mnuTelaPrincipalArquivoSair.Size = new Size(404, 26);
            mnuTelaPrincipalArquivoSair.Text = "Sai&r";
            // 
            // mnuTelaPrincipalArquivoSairDoPrograma
            // 
            mnuTelaPrincipalArquivoSairDoPrograma.Name = "mnuTelaPrincipalArquivoSairDoPrograma";
            mnuTelaPrincipalArquivoSairDoPrograma.Size = new Size(404, 26);
            mnuTelaPrincipalArquivoSairDoPrograma.Text = "Fechar o Aplicativo (só pd aparecer pra admin)";
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
            // 
            // mnuPrincipalAdminstradorUsuarios
            // 
            mnuPrincipalAdminstradorUsuarios.Name = "mnuPrincipalAdminstradorUsuarios";
            mnuPrincipalAdminstradorUsuarios.Size = new Size(274, 26);
            mnuPrincipalAdminstradorUsuarios.Text = "Gerenciamento de Usuarios";
            // 
            // registrarFrequênciaToolStripMenuItem
            // 
            registrarFrequênciaToolStripMenuItem.Name = "registrarFrequênciaToolStripMenuItem";
            registrarFrequênciaToolStripMenuItem.Size = new Size(274, 26);
            registrarFrequênciaToolStripMenuItem.Text = "Registrar Frequência";
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
            mnuPrincipalClientePerfil.Size = new Size(173, 26);
            mnuPrincipalClientePerfil.Text = "Perfil";
            // 
            // mnuPrincipalClienteFrequencia
            // 
            mnuPrincipalClienteFrequencia.Name = "mnuPrincipalClienteFrequencia";
            mnuPrincipalClienteFrequencia.Size = new Size(173, 26);
            mnuPrincipalClienteFrequencia.Text = "Frequência";
            // 
            // mnuPrincipalClienteTreinos
            // 
            mnuPrincipalClienteTreinos.Name = "mnuPrincipalClienteTreinos";
            mnuPrincipalClienteTreinos.Size = new Size(173, 26);
            mnuPrincipalClienteTreinos.Text = "Treinos";
            // 
            // mnuPrincipalClienteAvaliacoes
            // 
            mnuPrincipalClienteAvaliacoes.Name = "mnuPrincipalClienteAvaliacoes";
            mnuPrincipalClienteAvaliacoes.Size = new Size(173, 26);
            mnuPrincipalClienteAvaliacoes.Text = "Avaliações";
            // 
            // mnuPrincipalClientePagamentos
            // 
            mnuPrincipalClientePagamentos.Name = "mnuPrincipalClientePagamentos";
            mnuPrincipalClientePagamentos.Size = new Size(173, 26);
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
            // 
            // mnuPrincipalAjudaSobre
            // 
            mnuPrincipalAjudaSobre.Name = "mnuPrincipalAjudaSobre";
            mnuPrincipalAjudaSobre.Size = new Size(188, 26);
            mnuPrincipalAjudaSobre.Text = "Sobre";
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
    }
}