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
            btnEditarProgramacao = new Button();
            lstExercicios = new ListView();
            btnAdicionarProgramacao = new Button();
            treProgramacoes = new TreeView();
            pnlProgramacao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlProgramacao
            // 
            pnlProgramacao.Controls.Add(btnEditarProgramacao);
            pnlProgramacao.Controls.Add(lstExercicios);
            pnlProgramacao.Controls.Add(btnAdicionarProgramacao);
            pnlProgramacao.Controls.Add(treProgramacoes);
            pnlProgramacao.Location = new Point(12, 12);
            pnlProgramacao.Name = "pnlProgramacao";
            pnlProgramacao.Size = new Size(776, 426);
            pnlProgramacao.TabIndex = 0;
            // 
            // btnEditarProgramacao
            // 
            btnEditarProgramacao.Location = new Point(149, 400);
            btnEditarProgramacao.Name = "btnEditarProgramacao";
            btnEditarProgramacao.Size = new Size(140, 23);
            btnEditarProgramacao.TabIndex = 3;
            btnEditarProgramacao.Text = "Editar Programação";
            btnEditarProgramacao.UseVisualStyleBackColor = true;
            // 
            // lstExercicios
            // 
            lstExercicios.Location = new Point(193, 3);
            lstExercicios.Name = "lstExercicios";
            lstExercicios.Size = new Size(580, 391);
            lstExercicios.TabIndex = 2;
            lstExercicios.UseCompatibleStateImageBehavior = false;
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
        private Button btnEditarProgramacao;
        private ListView lstExercicios;
    }
}