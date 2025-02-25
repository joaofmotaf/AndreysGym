namespace AndreysGym.Forms
{
    partial class FrmProgramacao
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
            this.pnlProgramacao = new System.Windows.Forms.Panel();
            this.btnConcluirTreino = new System.Windows.Forms.Button();
            this.lstExercicios = new System.Windows.Forms.ListView();
            this.nomeExercicio = new System.Windows.Forms.ColumnHeader();
            this.series = new System.Windows.Forms.ColumnHeader();
            this.repeticoes = new System.Windows.Forms.ColumnHeader();
            this.btnAdicionarProgramacao = new System.Windows.Forms.Button();
            this.treProgramacoes = new System.Windows.Forms.TreeView();
            this.pnlProgramacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProgramacao
            // 
            this.pnlProgramacao.Controls.Add(this.btnConcluirTreino);
            this.pnlProgramacao.Controls.Add(this.lstExercicios);
            this.pnlProgramacao.Controls.Add(this.btnAdicionarProgramacao);
            this.pnlProgramacao.Controls.Add(this.treProgramacoes);
            this.pnlProgramacao.Location = new System.Drawing.Point(12, 12);
            this.pnlProgramacao.Name = "pnlProgramacao";
            this.pnlProgramacao.Size = new System.Drawing.Size(776, 388);
            this.pnlProgramacao.TabIndex = 0;
            // 
            // btnConcluirTreino
            // 
            this.btnConcluirTreino.Enabled = false;
            this.btnConcluirTreino.Location = new System.Drawing.Point(670, 316);
            this.btnConcluirTreino.Name = "btnConcluirTreino";
            this.btnConcluirTreino.Size = new System.Drawing.Size(103, 23);
            this.btnConcluirTreino.TabIndex = 3;
            this.btnConcluirTreino.Text = "Concluir Treino";
            this.btnConcluirTreino.UseVisualStyleBackColor = true;
            this.btnConcluirTreino.Click += new System.EventHandler(this.btnConcluirTreino_Click);
            // 
            // lstExercicios
            // 
            this.lstExercicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeExercicio,
            this.series,
            this.repeticoes});
            this.lstExercicios.FullRowSelect = true;
            this.lstExercicios.GridLines = true;
            this.lstExercicios.Location = new System.Drawing.Point(193, 3);
            this.lstExercicios.Name = "lstExercicios";
            this.lstExercicios.Size = new System.Drawing.Size(580, 307);
            this.lstExercicios.TabIndex = 2;
            this.lstExercicios.UseCompatibleStateImageBehavior = false;
            this.lstExercicios.View = System.Windows.Forms.View.Details;
            // 
            // nomeExercicio
            // 
            this.nomeExercicio.Text = "Nome do Exercício";
            this.nomeExercicio.Width = 250;
            // 
            // series
            // 
            this.series.Text = "Séries";
            this.series.Width = 70;
            // 
            // repeticoes
            // 
            this.repeticoes.Text = "Repetições";
            this.repeticoes.Width = 90;
            // 
            // btnAdicionarProgramacao
            // 
            this.btnAdicionarProgramacao.Location = new System.Drawing.Point(3, 358);
            this.btnAdicionarProgramacao.Name = "btnAdicionarProgramacao";
            this.btnAdicionarProgramacao.Size = new System.Drawing.Size(140, 23);
            this.btnAdicionarProgramacao.TabIndex = 1;
            this.btnAdicionarProgramacao.Text = "Adicionar Programação";
            this.btnAdicionarProgramacao.UseVisualStyleBackColor = true;
            this.btnAdicionarProgramacao.Click += new System.EventHandler(this.btnAdicionarProgramacao_Click);
            // 
            // treProgramacoes
            // 
            this.treProgramacoes.Location = new System.Drawing.Point(3, 3);
            this.treProgramacoes.Name = "treProgramacoes";
            this.treProgramacoes.Size = new System.Drawing.Size(184, 349);
            this.treProgramacoes.TabIndex = 0;
            this.treProgramacoes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvProgramacoes_AfterSelect);
            // 
            // FrmProgramacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.pnlProgramacao);
            this.Name = "FrmProgramacao";
            this.Text = "Programações";
            this.pnlProgramacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlProgramacao;
        private TreeView treProgramacoes;
        private Button btnAdicionarProgramacao;
        private ListView lstExercicios;
        private ColumnHeader nomeExercicio;
        private ColumnHeader series;
        private ColumnHeader repeticoes;
        private Button btnConcluirTreino;
    }
}