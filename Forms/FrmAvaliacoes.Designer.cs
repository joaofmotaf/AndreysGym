﻿namespace AndreysGym.Forms
{
    partial class FrmAvaliacoes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstAvaliacoes = new System.Windows.Forms.ListBox();
            this.btnCadastrarAvaliacao = new System.Windows.Forms.Button();
            this.proAvaliacao = new System.Windows.Forms.PropertyGrid();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstAvaliacoes);
            this.panel1.Controls.Add(this.btnCadastrarAvaliacao);
            this.panel1.Controls.Add(this.proAvaliacao);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 369);
            this.panel1.TabIndex = 0;
            // 
            // lstAvaliacoes
            // 
            this.lstAvaliacoes.FormattingEnabled = true;
            this.lstAvaliacoes.ItemHeight = 15;
            this.lstAvaliacoes.Location = new System.Drawing.Point(3, 3);
            this.lstAvaliacoes.Name = "lstAvaliacoes";
            this.lstAvaliacoes.Size = new System.Drawing.Size(206, 334);
            this.lstAvaliacoes.TabIndex = 3;
            this.lstAvaliacoes.SelectedIndexChanged += new System.EventHandler(this.lstAvaliacoes_SelectedIndexChanged);
            // 
            // btnCadastrarAvaliacao
            // 
            this.btnCadastrarAvaliacao.Location = new System.Drawing.Point(3, 343);
            this.btnCadastrarAvaliacao.Name = "btnCadastrarAvaliacao";
            this.btnCadastrarAvaliacao.Size = new System.Drawing.Size(206, 23);
            this.btnCadastrarAvaliacao.TabIndex = 2;
            this.btnCadastrarAvaliacao.Text = "Cadastrar Avaliação";
            this.btnCadastrarAvaliacao.UseVisualStyleBackColor = true;
            this.btnCadastrarAvaliacao.Click += new System.EventHandler(this.btnCadastrarAvaliacao_Click);
            // 
            // proAvaliacao
            // 
            this.proAvaliacao.Location = new System.Drawing.Point(215, 0);
            this.proAvaliacao.Name = "proAvaliacao";
            this.proAvaliacao.Size = new System.Drawing.Size(561, 360);
            this.proAvaliacao.TabIndex = 0;
            // 
            // FrmAvaliacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAvaliacoes";
            this.Text = "FrmAvaliacoes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PropertyGrid proAvaliacao;
        private Button btnCadastrarAvaliacao;
        private ListBox lstAvaliacoes;
    }
}