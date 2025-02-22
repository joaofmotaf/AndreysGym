namespace AndreysGym.Forms
{
    partial class FrmRegistroProgramacao
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
            pnlRegistroProgramacao = new Panel();
            trvProgramacoes = new TreeView();
            pnlRegistroProgramacao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegistroProgramacao
            // 
            pnlRegistroProgramacao.Controls.Add(trvProgramacoes);
            pnlRegistroProgramacao.Location = new Point(12, 12);
            pnlRegistroProgramacao.Name = "pnlRegistroProgramacao";
            pnlRegistroProgramacao.Size = new Size(776, 426);
            pnlRegistroProgramacao.TabIndex = 0;
            // 
            // trvProgramacoes
            // 
            trvProgramacoes.Location = new Point(3, 3);
            trvProgramacoes.Name = "trvProgramacoes";
            trvProgramacoes.Size = new Size(184, 420);
            trvProgramacoes.TabIndex = 0;
            // 
            // FrmRegistroProgramacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegistroProgramacao);
            Name = "FrmRegistroProgramacao";
            Text = "FrmRegistroProgramacao";
            pnlRegistroProgramacao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegistroProgramacao;
        private TreeView trvProgramacoes;
    }
}