namespace AndreysGym.Forms
{
    partial class FrmPagamentos
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
            pnlPagamentos = new Panel();
            lstPagamentos = new ListBox();
            btnNovoPagamento = new Button();
            pnlPagamentos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPagamentos
            // 
            pnlPagamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPagamentos.Controls.Add(btnNovoPagamento);
            pnlPagamentos.Controls.Add(lstPagamentos);
            pnlPagamentos.Location = new Point(12, 12);
            pnlPagamentos.Name = "pnlPagamentos";
            pnlPagamentos.Size = new Size(776, 426);
            pnlPagamentos.TabIndex = 0;
            // 
            // lstPagamentos
            // 
            lstPagamentos.FormattingEnabled = true;
            lstPagamentos.ItemHeight = 15;
            lstPagamentos.Location = new Point(149, 15);
            lstPagamentos.Name = "lstPagamentos";
            lstPagamentos.Size = new Size(443, 274);
            lstPagamentos.TabIndex = 0;
            // 
            // btnNovoPagamento
            // 
            btnNovoPagamento.Location = new Point(479, 295);
            btnNovoPagamento.Name = "btnNovoPagamento";
            btnNovoPagamento.Size = new Size(113, 23);
            btnNovoPagamento.TabIndex = 1;
            btnNovoPagamento.Text = "Novo Pagamento";
            btnNovoPagamento.UseVisualStyleBackColor = true;
            // 
            // FrmPagamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPagamentos);
            Name = "FrmPagamentos";
            Text = "FrmPagamentos";
            pnlPagamentos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPagamentos;
        private Button btnNovoPagamento;
        private ListBox lstPagamentos;
    }
}