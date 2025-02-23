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
            pnlProgramacao = new Panel();
            btnConcluirTreino = new Button();
            lstExercicios = new ListView();
            nomeExercicio = new ColumnHeader();
            series = new ColumnHeader();
            repeticoes = new ColumnHeader();
            btnAdicionarProgramacao = new Button();
            treProgramacoes = new TreeView();
            pnlProgramacao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlProgramacao
            // 
            pnlProgramacao.Controls.Add(btnConcluirTreino);
            pnlProgramacao.Controls.Add(lstExercicios);
            pnlProgramacao.Controls.Add(btnAdicionarProgramacao);
            pnlProgramacao.Controls.Add(treProgramacoes);
            pnlProgramacao.Location = new Point(12, 12);
            pnlProgramacao.Name = "pnlProgramacao";
            pnlProgramacao.Size = new Size(776, 426);
            pnlProgramacao.TabIndex = 0;
            // 
            // btnConcluirTreino
            // 
            btnConcluirTreino.Enabled = false;
            btnConcluirTreino.Location = new Point(670, 371);
            btnConcluirTreino.Name = "btnConcluirTreino";
            btnConcluirTreino.Size = new Size(103, 23);
            btnConcluirTreino.TabIndex = 3;
            btnConcluirTreino.Text = "Concluir Treino";
            btnConcluirTreino.UseVisualStyleBackColor = true;
            btnConcluirTreino.Click += btnConcluirTreino_Click;
            // 
            // lstExercicios
            // 
            lstExercicios.Columns.AddRange(new ColumnHeader[] { nomeExercicio, series, repeticoes });
            lstExercicios.FullRowSelect = true;
            lstExercicios.GridLines = true;
            lstExercicios.Location = new Point(193, 3);
            lstExercicios.Name = "lstExercicios";
            lstExercicios.Size = new Size(580, 351);
            lstExercicios.TabIndex = 2;
            lstExercicios.UseCompatibleStateImageBehavior = false;
            lstExercicios.View = View.Details;
            // 
            // nomeExercicio
            // 
            nomeExercicio.Text = "Nome do Exercício";
            nomeExercicio.Width = 250;
            // 
            // series
            // 
            series.Text = "Séries";
            series.Width = 70;
            // 
            // repeticoes
            // 
            repeticoes.Text = "Repetições";
            repeticoes.Width = 90;
            // 
            // btnAdicionarProgramacao
            // 
            btnAdicionarProgramacao.Location = new Point(3, 400);
            btnAdicionarProgramacao.Name = "btnAdicionarProgramacao";
            btnAdicionarProgramacao.Size = new Size(140, 23);
            btnAdicionarProgramacao.TabIndex = 1;
            btnAdicionarProgramacao.Text = "Adicionar Programação";
            btnAdicionarProgramacao.UseVisualStyleBackColor = true;
            btnAdicionarProgramacao.Click += btnAdicionarProgramacao_Click;
            // 
            // treProgramacoes
            // 
            treProgramacoes.Location = new Point(3, 3);
            treProgramacoes.Name = "treProgramacoes";
            treProgramacoes.Size = new Size(184, 391);
            treProgramacoes.TabIndex = 0;
            treProgramacoes.AfterSelect += trvProgramacoes_AfterSelect;
            // 
            // FrmProgramacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlProgramacao);
            Name = "FrmProgramacao";
            Text = "Programações";
            pnlProgramacao.ResumeLayout(false);
            ResumeLayout(false);
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