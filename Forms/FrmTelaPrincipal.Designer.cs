﻿namespace AndreysGym.Forms
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
            this.mnuTelaPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuPrincipalArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTelaPrincipalArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTelaPrincipalArquivoSairDoPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAdmnistrador = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAdmnistradorCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAdminstradorUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarFrequênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalClientePerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalClienteFrequencia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalClienteTreinos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalClienteAvaliacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalClientePagamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAjudaTermosDeUso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTelaPrincipal
            // 
            this.mnuTelaPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTelaPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalArquivoSair,
            this.mnuPrincipalAdmnistrador,
            this.mnuPrincipalCliente,
            this.mnuPrincipalAjuda});
            this.mnuTelaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuTelaPrincipal.Name = "mnuTelaPrincipal";
            this.mnuTelaPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuTelaPrincipal.TabIndex = 9;
            this.mnuTelaPrincipal.Text = "menuStrip1";
            // 
            // mnuPrincipalArquivoSair
            // 
            this.mnuPrincipalArquivoSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTelaPrincipalArquivoSair,
            this.mnuTelaPrincipalArquivoSairDoPrograma});
            this.mnuPrincipalArquivoSair.Name = "mnuPrincipalArquivoSair";
            this.mnuPrincipalArquivoSair.Size = new System.Drawing.Size(61, 20);
            this.mnuPrincipalArquivoSair.Text = "A&rquivo";
            // 
            // mnuTelaPrincipalArquivoSair
            // 
            this.mnuTelaPrincipalArquivoSair.Image = global::AndreysGym.Properties.Resources.free_exit_icon_2860_thumb;
            this.mnuTelaPrincipalArquivoSair.Name = "mnuTelaPrincipalArquivoSair";
            this.mnuTelaPrincipalArquivoSair.Size = new System.Drawing.Size(320, 22);
            this.mnuTelaPrincipalArquivoSair.Text = "Sai&r";
            this.mnuTelaPrincipalArquivoSair.Click += new System.EventHandler(this.mnuTelaPrincipalArquivoSair_Click);
            // 
            // mnuTelaPrincipalArquivoSairDoPrograma
            // 
            this.mnuTelaPrincipalArquivoSairDoPrograma.Name = "mnuTelaPrincipalArquivoSairDoPrograma";
            this.mnuTelaPrincipalArquivoSairDoPrograma.Size = new System.Drawing.Size(320, 22);
            this.mnuTelaPrincipalArquivoSairDoPrograma.Text = "Fechar o Aplicativo (só pd aparecer pra admin)";
            this.mnuTelaPrincipalArquivoSairDoPrograma.Click += new System.EventHandler(this.mnuTelaPrincipalArquivoSairDoPrograma_Click);
            // 
            // mnuPrincipalAdmnistrador
            // 
            this.mnuPrincipalAdmnistrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalAdmnistradorCadastrar,
            this.mnuPrincipalAdminstradorUsuarios,
            this.registrarFrequênciaToolStripMenuItem});
            this.mnuPrincipalAdmnistrador.Name = "mnuPrincipalAdmnistrador";
            this.mnuPrincipalAdmnistrador.Size = new System.Drawing.Size(139, 20);
            this.mnuPrincipalAdmnistrador.Text = "Área do &Administrador";
            // 
            // mnuPrincipalAdmnistradorCadastrar
            // 
            this.mnuPrincipalAdmnistradorCadastrar.Name = "mnuPrincipalAdmnistradorCadastrar";
            this.mnuPrincipalAdmnistradorCadastrar.Size = new System.Drawing.Size(219, 22);
            this.mnuPrincipalAdmnistradorCadastrar.Text = "Cadastrar usuário";
            this.mnuPrincipalAdmnistradorCadastrar.Click += new System.EventHandler(this.mnuPrincipalAdmnistradorCadastrar_Click);
            // 
            // mnuPrincipalAdminstradorUsuarios
            // 
            this.mnuPrincipalAdminstradorUsuarios.Name = "mnuPrincipalAdminstradorUsuarios";
            this.mnuPrincipalAdminstradorUsuarios.Size = new System.Drawing.Size(219, 22);
            this.mnuPrincipalAdminstradorUsuarios.Text = "Gerenciamento de Usuarios";
            this.mnuPrincipalAdminstradorUsuarios.Click += new System.EventHandler(this.mnuPrincipalAdminstradorUsuarios_Click);
            // 
            // registrarFrequênciaToolStripMenuItem
            // 
            this.registrarFrequênciaToolStripMenuItem.Name = "registrarFrequênciaToolStripMenuItem";
            this.registrarFrequênciaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.registrarFrequênciaToolStripMenuItem.Text = "Registrar Frequência";
            this.registrarFrequênciaToolStripMenuItem.Click += new System.EventHandler(this.registrarFrequênciaToolStripMenuItem_Click);
            // 
            // mnuPrincipalCliente
            // 
            this.mnuPrincipalCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalClientePerfil,
            this.mnuPrincipalClienteFrequencia,
            this.mnuPrincipalClienteTreinos,
            this.mnuPrincipalClienteAvaliacoes,
            this.mnuPrincipalClientePagamentos});
            this.mnuPrincipalCliente.Name = "mnuPrincipalCliente";
            this.mnuPrincipalCliente.Size = new System.Drawing.Size(100, 20);
            this.mnuPrincipalCliente.Text = "Área do &Cliente";
            // 
            // mnuPrincipalClientePerfil
            // 
            this.mnuPrincipalClientePerfil.Name = "mnuPrincipalClientePerfil";
            this.mnuPrincipalClientePerfil.Size = new System.Drawing.Size(140, 22);
            this.mnuPrincipalClientePerfil.Text = "Perfil";
            this.mnuPrincipalClientePerfil.Click += new System.EventHandler(this.mnuPrincipalClientePerfil_Click);
            // 
            // mnuPrincipalClienteFrequencia
            // 
            this.mnuPrincipalClienteFrequencia.Name = "mnuPrincipalClienteFrequencia";
            this.mnuPrincipalClienteFrequencia.Size = new System.Drawing.Size(140, 22);
            this.mnuPrincipalClienteFrequencia.Text = "Frequência";
            this.mnuPrincipalClienteFrequencia.Click += new System.EventHandler(this.mnuPrincipalClienteFrequencia_Click);
            // 
            // mnuPrincipalClienteTreinos
            // 
            this.mnuPrincipalClienteTreinos.Name = "mnuPrincipalClienteTreinos";
            this.mnuPrincipalClienteTreinos.Size = new System.Drawing.Size(140, 22);
            this.mnuPrincipalClienteTreinos.Text = "Treinos";
            this.mnuPrincipalClienteTreinos.Click += new System.EventHandler(this.mnuPrincipalClienteTreinos_Click);
            // 
            // mnuPrincipalClienteAvaliacoes
            // 
            this.mnuPrincipalClienteAvaliacoes.Name = "mnuPrincipalClienteAvaliacoes";
            this.mnuPrincipalClienteAvaliacoes.Size = new System.Drawing.Size(140, 22);
            this.mnuPrincipalClienteAvaliacoes.Text = "Avaliações";
            this.mnuPrincipalClienteAvaliacoes.Click += new System.EventHandler(this.mnuPrincipalClienteAvaliacoes_Click);
            // 
            // mnuPrincipalClientePagamentos
            // 
            this.mnuPrincipalClientePagamentos.Name = "mnuPrincipalClientePagamentos";
            this.mnuPrincipalClientePagamentos.Size = new System.Drawing.Size(140, 22);
            this.mnuPrincipalClientePagamentos.Text = "Pagamentos";
            // 
            // mnuPrincipalAjuda
            // 
            this.mnuPrincipalAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalAjudaTermosDeUso,
            this.mnuPrincipalAjudaSobre});
            this.mnuPrincipalAjuda.Name = "mnuPrincipalAjuda";
            this.mnuPrincipalAjuda.Size = new System.Drawing.Size(50, 20);
            this.mnuPrincipalAjuda.Text = "A&juda";
            // 
            // mnuPrincipalAjudaTermosDeUso
            // 
            this.mnuPrincipalAjudaTermosDeUso.Name = "mnuPrincipalAjudaTermosDeUso";
            this.mnuPrincipalAjudaTermosDeUso.Size = new System.Drawing.Size(150, 22);
            this.mnuPrincipalAjudaTermosDeUso.Text = "Termos de uso";
            // 
            // mnuPrincipalAjudaSobre
            // 
            this.mnuPrincipalAjudaSobre.Name = "mnuPrincipalAjudaSobre";
            this.mnuPrincipalAjudaSobre.Size = new System.Drawing.Size(150, 22);
            this.mnuPrincipalAjudaSobre.Text = "Sobre";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AndreysGym.Properties.Resources.image_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuTelaPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Tela Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTelaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuTelaPrincipal.ResumeLayout(false);
            this.mnuTelaPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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