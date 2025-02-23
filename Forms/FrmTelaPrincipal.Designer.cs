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
            mnuTelaPrincipal.Size = new Size(800, 24);
            mnuTelaPrincipal.TabIndex = 1;
            mnuTelaPrincipal.Text = "menuStrip1";
            // 
            // mnuPrincipalArquivoSair
            // 
            mnuPrincipalArquivoSair.DropDownItems.AddRange(new ToolStripItem[] { mnuTelaPrincipalArquivoSair, mnuTelaPrincipalArquivoSairDoPrograma });
            mnuPrincipalArquivoSair.Name = "mnuPrincipalArquivoSair";
            mnuPrincipalArquivoSair.Size = new Size(61, 20);
            mnuPrincipalArquivoSair.Text = "A&rquivo";
            // 
            // mnuTelaPrincipalArquivoSair
            // 
            mnuTelaPrincipalArquivoSair.Image = Properties.Resources.free_exit_icon_2860_thumb;
            mnuTelaPrincipalArquivoSair.Name = "mnuTelaPrincipalArquivoSair";
            mnuTelaPrincipalArquivoSair.Size = new Size(320, 22);
            mnuTelaPrincipalArquivoSair.Text = "Sai&r";
            mnuTelaPrincipalArquivoSair.Click += mnuTelaPrincipalArquivoSair_Click;
            // 
            // mnuTelaPrincipalArquivoSairDoPrograma
            // 
            mnuTelaPrincipalArquivoSairDoPrograma.Name = "mnuTelaPrincipalArquivoSairDoPrograma";
            mnuTelaPrincipalArquivoSairDoPrograma.Size = new Size(320, 22);
            mnuTelaPrincipalArquivoSairDoPrograma.Text = "Fechar o Aplicativo (só pd aparecer pra admin)";
            mnuTelaPrincipalArquivoSairDoPrograma.Click += mnuTelaPrincipalArquivoSairDoPrograma_Click;
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
            mnuPrincipalClientePerfil.Size = new Size(180, 22);
            mnuPrincipalClientePerfil.Text = "Perfil";
            mnuPrincipalClientePerfil.Click += mnuPrincipalClientePerfil_Click;
            // 
            // mnuPrincipalClienteFrequencia
            // 
            mnuPrincipalClienteFrequencia.Name = "mnuPrincipalClienteFrequencia";
            mnuPrincipalClienteFrequencia.Size = new Size(180, 22);
            mnuPrincipalClienteFrequencia.Text = "Frequência";
            mnuPrincipalClienteFrequencia.Click += mnuPrincipalClienteFrequencia_Click;
            // 
            // mnuPrincipalClienteTreinos
            // 
            mnuPrincipalClienteTreinos.Name = "mnuPrincipalClienteTreinos";
            mnuPrincipalClienteTreinos.Size = new Size(180, 22);
            mnuPrincipalClienteTreinos.Text = "Treinos";
            mnuPrincipalClienteTreinos.Click += mnuPrincipalClienteTreinos_Click;
            // 
            // mnuPrincipalClienteAvaliacoes
            // 
            mnuPrincipalClienteAvaliacoes.Name = "mnuPrincipalClienteAvaliacoes";
            mnuPrincipalClienteAvaliacoes.Size = new Size(180, 22);
            mnuPrincipalClienteAvaliacoes.Text = "Avaliações";
            // 
            // mnuPrincipalClientePagamentos
            // 
            mnuPrincipalClientePagamentos.Name = "mnuPrincipalClientePagamentos";
            mnuPrincipalClientePagamentos.Size = new Size(180, 22);
            mnuPrincipalClientePagamentos.Text = "Pagamentos";
            // 
            // mnuPrincipalAjuda
            // 
            mnuPrincipalAjuda.DropDownItems.AddRange(new ToolStripItem[] { mnuPrincipalAjudaTermosDeUso, mnuPrincipalAjudaSobre });
            mnuPrincipalAjuda.Name = "mnuPrincipalAjuda";
            mnuPrincipalAjuda.Size = new Size(50, 20);
            mnuPrincipalAjuda.Text = "A&juda";
            // 
            // mnuPrincipalAjudaTermosDeUso
            // 
            mnuPrincipalAjudaTermosDeUso.Name = "mnuPrincipalAjudaTermosDeUso";
            mnuPrincipalAjudaTermosDeUso.Size = new Size(151, 22);
            mnuPrincipalAjudaTermosDeUso.Text = "Termos de uso";
            mnuPrincipalAjudaTermosDeUso.Click += mnuPrincipalAjudaTermosDeUso_Click;
            // 
            // mnuPrincipalAjudaSobre
            // 
            mnuPrincipalAjudaSobre.Name = "mnuPrincipalAjudaSobre";
            mnuPrincipalAjudaSobre.Size = new Size(151, 22);
            mnuPrincipalAjudaSobre.Text = "Sobre";
            mnuPrincipalAjudaSobre.Click += mnuPrincipalAjudaSobre_Click;
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